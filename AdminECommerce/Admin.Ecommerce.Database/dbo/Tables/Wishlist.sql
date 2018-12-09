CREATE TABLE [dbo].[Wishlist] (
    [AccountID] VARCHAR (50) NOT NULL,
    [ProductID] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_dbo.Wishlist] PRIMARY KEY CLUSTERED ([AccountID] ASC, [ProductID] ASC),
    CONSTRAINT [FK_dbo.Wishlist_dbo.Accounts_AccountID] FOREIGN KEY ([AccountID]) REFERENCES [dbo].[Accounts] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.Wishlist_dbo.Products_ProductID] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Products] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_AccountID]
    ON [dbo].[Wishlist]([AccountID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_ProductID]
    ON [dbo].[Wishlist]([ProductID] ASC);

