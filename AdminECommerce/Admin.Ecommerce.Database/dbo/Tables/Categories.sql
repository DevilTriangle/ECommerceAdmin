CREATE TABLE [dbo].[Categories] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (50)   NOT NULL,
    [AttName1]  NVARCHAR (255) NULL,
    [AttName2]  NVARCHAR (255) NULL,
    [AttName3]  NVARCHAR (255) NULL,
    [AttName4]  NVARCHAR (255) NULL,
    [AttName5]  NVARCHAR (255) NULL,
    [AttName6]  NVARCHAR (255) NULL,
    [AttName7]  NVARCHAR (255) NULL,
    [AttName8]  NVARCHAR (255) NULL,
    [AttName9]  NVARCHAR (255) NULL,
    [AttName10] NVARCHAR (255) NULL,
    [Image]     NVARCHAR (100) NULL,
    [IsActive]  BIT            NULL,
    CONSTRAINT [PK_dbo.Categories] PRIMARY KEY CLUSTERED ([Id] ASC)
);

