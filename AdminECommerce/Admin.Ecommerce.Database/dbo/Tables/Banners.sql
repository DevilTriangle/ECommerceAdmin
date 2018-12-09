CREATE TABLE [dbo].[Banners] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [ProductID] VARCHAR (50) NULL,
    [Image]     VARCHAR (50) NULL,
    CONSTRAINT [PK_dbo.Banners] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Banners_dbo.Products_ProductID] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Products] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_ProductID]
    ON [dbo].[Banners]([ProductID] ASC);

