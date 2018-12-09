CREATE TABLE [dbo].[Reviews] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [ProductId] VARCHAR (50)   NULL,
    [Title]     NVARCHAR (255) NULL,
    [AccountId] VARCHAR (50)   NULL,
    [Content]   NVARCHAR (MAX) NULL,
    [Rating]    INT            NULL,
    [IsActive]  BIT            NULL,
    CONSTRAINT [PK_dbo.Reviews] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Reviews_dbo.Accounts_AccountId] FOREIGN KEY ([AccountId]) REFERENCES [dbo].[Accounts] ([Id]),
    CONSTRAINT [FK_dbo.Reviews_dbo.Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_AccountId]
    ON [dbo].[Reviews]([AccountId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_ProductId]
    ON [dbo].[Reviews]([ProductId] ASC);

