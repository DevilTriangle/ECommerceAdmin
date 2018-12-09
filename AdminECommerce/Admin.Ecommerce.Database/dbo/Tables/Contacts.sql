CREATE TABLE [dbo].[Contacts] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Address]   VARCHAR (255) NULL,
    [LandLine]  VARCHAR (50)  NULL,
    [CellPhone] VARCHAR (50)  NULL,
    [Email]     VARCHAR (50)  NULL,
    [Skype]     VARCHAR (255) NULL,
    [Facebook]  VARCHAR (255) NULL,
    [Gmail]     VARCHAR (255) NULL,
    [Twitter]   VARCHAR (255) NULL,
    [Instagram] VARCHAR (255) NULL,
    [Working]   VARCHAR (255) NULL,
    [AccountID] VARCHAR (50)  NULL,
    CONSTRAINT [PK_dbo.Contacts] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Contacts_dbo.Accounts_AccountID] FOREIGN KEY ([AccountID]) REFERENCES [dbo].[Accounts] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_AccountID]
    ON [dbo].[Contacts]([AccountID] ASC);

