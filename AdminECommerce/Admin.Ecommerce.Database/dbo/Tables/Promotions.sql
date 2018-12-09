CREATE TABLE [dbo].[Promotions] (
    [Id]          VARCHAR (50)  NOT NULL,
    [Discount]    FLOAT (53)    NOT NULL,
    [Description] VARCHAR (MAX) NULL,
    [Type]        INT           NOT NULL,
    [ProductID]   VARCHAR (50)  NULL,
    [AccountID]   VARCHAR (50)  NOT NULL,
    [StartTime]   DATETIME      NULL,
    [EndTime]     DATETIME      NOT NULL,
    CONSTRAINT [PK_dbo.Promotions] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Promotions_dbo.Products_ProductID] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Products] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_ProductID]
    ON [dbo].[Promotions]([ProductID] ASC);

