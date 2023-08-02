USE StockData
GO

CREATE TABLE Item
(
  Id INT IDENTITY PRIMARY KEY,
  [Name] NVARCHAR(120) NOT NULL,
  [Description] NVARCHAR(2000) NOT NULL,
  QuantityOfGoods INT DEFAULT 0 CHECK (QuantityOfGoods >= 0),
  Price MONEY DEFAULT 0 CHECK (Price >= 0.0),
  TypeId INT
)

CREATE TABLE [Type]
(
  Id INT IDENTITY PRIMARY KEY,
  [Type] NVARCHAR(50) NOT NULL
)

CREATE TABLE Storage
(
  Id INT IDENTITY PRIMARY KEY,
  ItemId INT,
  UserId INT
)

CREATE TABLE Users
(
  Id INT IDENTITY PRIMARY KEY,
  [Login] NVARCHAR(100) NOT NULL UNIQUE,
  [Password] NVARCHAR(100) NOT NULL,
  FirstName NVARCHAR(100) NOT NULL,
  LastName NVARCHAR(100) NOT NULL,
  [isRoot] BIT NOT NULL
)
GO

CREATE PROCEDURE sp_add_item_to_Storage
    @Name NVARCHAR(120),
    @Description NVARCHAR(2000),
    @QuantityOfGoods INT,
    @Price MONEY,
    @TypeId INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Users WHERE [Login] = CURRENT_USER AND [isRoot] = 1)
    BEGIN
        -- Insert the item into the Item table
        INSERT INTO Item ([Name], [Description], QuantityOfGoods, Price, TypeId)
        VALUES (@Name, @Description, @QuantityOfGoods, @Price, @TypeId)

        PRINT ('Item added to the warehouse successfully.')
    END
    ELSE
    BEGIN
        PRINT ('You do not have the required permissions to perform this action.')
    END
END
GO

CREATE PROCEDURE sp_edit_item_in_Storage 
    @ItemId INT,
    @NewItemName NVARCHAR(120),
    @NewDescription NVARCHAR(2000),
    @NewQuantityOfGoods INT,
    @NewPrice MONEY
AS
BEGIN
    -- Check if the current user has root rights
    IF EXISTS (SELECT 1 FROM Users WHERE [Login] = CURRENT_USER AND [isRoot] = 1)
    BEGIN
        -- Check if the item exists in the storage
        IF EXISTS (SELECT 1 FROM Item WHERE Id = @ItemId)
        BEGIN
            -- Update the item in the storage
            UPDATE Item
            SET [Name] = @NewItemName,
                [Description] = @NewDescription,
                QuantityOfGoods = @NewQuantityOfGoods,
                Price = @NewPrice
            WHERE Id = @ItemId;

            PRINT ('Item in the storage updated successfully.')
        END
        ELSE
        BEGIN
            PRINT ('Item does not exist in the storage.')
        END
    END
    ELSE
    BEGIN
        PRINT ('You do not have the required permissions to perform this action.')
    END
END
GO

CREATE PROCEDURE sp_delete_item_in_Storage 
    @ItemId INT
AS
BEGIN
    -- Check if the current user has root rights
    IF EXISTS (SELECT 1 FROM Users WHERE [Login] = CURRENT_USER AND [isRoot] = 1)
    BEGIN
        -- Check if the item exists in the storage
        IF EXISTS (SELECT 1 FROM Item WHERE Id = @ItemId)
        BEGIN
            -- Remove the item from the storage
            DELETE FROM Item WHERE Id = @ItemId

            PRINT ('Item removed from the storage successfully.')
        END
        ELSE
        BEGIN
            PRINT ('Item does not exist in the storage.')
        END
    END
    ELSE
    BEGIN
        PRINT ('You do not have the required permissions to perform this action.')
    END
END