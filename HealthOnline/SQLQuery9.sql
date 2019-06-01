CREATE TABLE [dbo].[QuestionLists] (
    [Id]                  INT            IDENTITY (1, 1) NOT NULL,
    [SymptomDescriptions] NVARCHAR (MAX) NOT NULL,
    [HappenDate]          NVARCHAR (MAX) NOT NULL,
    [UserId]              NVARCHAR (MAX) NOT NULL,
	[Age]				INT NOT NULL
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
