CREATE TABLE [dbo].[Orders] (
    [ID]            VARCHAR (50)   NOT NULL,
    [AccountID]     VARCHAR (50)   NOT NULL,
    [DatePurchased] DATETIME       CONSTRAINT [DF_Orders_DatePurchased] DEFAULT (getdate()) NOT NULL,
    [Status]        VARCHAR (50)   NOT NULL,
    [Total]         FLOAT (53)     NOT NULL,
    [Name]          NVARCHAR (50)  NULL,
    [Phone]         VARCHAR (50)   NULL,
    [Address]       NVARCHAR (MAX) NULL,
    [Email]         VARCHAR (50)   NULL,
    CONSTRAINT [PK_dbo.Orders] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_dbo.Orders_dbo.Accounts_AccountID] FOREIGN KEY ([AccountID]) REFERENCES [dbo].[Accounts] ([Id])
);




GO
CREATE NONCLUSTERED INDEX [IX_AccountID]
    ON [dbo].[Orders]([AccountID] ASC);

