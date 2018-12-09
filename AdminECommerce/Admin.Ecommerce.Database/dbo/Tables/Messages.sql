CREATE TABLE [dbo].[Messages] (
    [ID]                INT            IDENTITY (1, 1) NOT NULL,
    [Name]              VARCHAR (50)   NULL,
    [Email]             VARCHAR (50)   NULL,
    [Message]           NVARCHAR (MAX) NULL,
    [AccountID]         VARCHAR (50)   NULL,
    [IsAnswered]        BIT            NULL,
    [AnsweredAccountId] NVARCHAR (128) NULL,
    [Answer]            NVARCHAR (MAX) NULL,
    [Status]            BIT            NULL,
    CONSTRAINT [PK_dbo.Messages] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_dbo.Messages_dbo.Accounts_AccountID] FOREIGN KEY ([AccountID]) REFERENCES [dbo].[Accounts] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_AccountID]
    ON [dbo].[Messages]([AccountID] ASC);

