IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181130095815_3')
BEGIN
    CREATE TABLE [Users] (
        [UserID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Password] nvarchar(max) NULL,
        [City] nvarchar(max) NULL,
        [State] nvarchar(max) NULL,
        CONSTRAINT [PK_Users] PRIMARY KEY ([UserID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181130095815_3')
BEGIN
    CREATE TABLE [Artists] (
        [ArtistID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [City] nvarchar(max) NULL,
        [State] nvarchar(max) NULL,
        [UserID] int NULL,
        CONSTRAINT [PK_Artists] PRIMARY KEY ([ArtistID]),
        CONSTRAINT [FK_Artists_Users_UserID] FOREIGN KEY ([UserID]) REFERENCES [Users] ([UserID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181130095815_3')
BEGIN
    CREATE TABLE [Venues] (
        [VenueID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [City] nvarchar(max) NULL,
        [State] nvarchar(max) NULL,
        [UserID] int NULL,
        CONSTRAINT [PK_Venues] PRIMARY KEY ([VenueID]),
        CONSTRAINT [FK_Venues_Users_UserID] FOREIGN KEY ([UserID]) REFERENCES [Users] ([UserID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181130095815_3')
BEGIN
    CREATE TABLE [Messages] (
        [MessageID] int NOT NULL IDENTITY,
        [Unread] bit NOT NULL,
        [Time] datetime2 NOT NULL,
        [Sender] nvarchar(max) NULL,
        [ArtistID] int NULL,
        [UserID] int NULL,
        [VenueID] int NULL,
        CONSTRAINT [PK_Messages] PRIMARY KEY ([MessageID]),
        CONSTRAINT [FK_Messages_Artists_ArtistID] FOREIGN KEY ([ArtistID]) REFERENCES [Artists] ([ArtistID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Messages_Users_UserID] FOREIGN KEY ([UserID]) REFERENCES [Users] ([UserID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Messages_Venues_VenueID] FOREIGN KEY ([VenueID]) REFERENCES [Venues] ([VenueID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181130095815_3')
BEGIN
    CREATE TABLE [Shows] (
        [ShowID] int NOT NULL IDENTITY,
        [VenueID] int NULL,
        [Time] datetime2 NOT NULL,
        [Cost] decimal(18, 2) NOT NULL,
        CONSTRAINT [PK_Shows] PRIMARY KEY ([ShowID]),
        CONSTRAINT [FK_Shows_Venues_VenueID] FOREIGN KEY ([VenueID]) REFERENCES [Venues] ([VenueID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181130095815_3')
BEGIN
    CREATE INDEX [IX_Artists_UserID] ON [Artists] ([UserID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181130095815_3')
BEGIN
    CREATE INDEX [IX_Messages_ArtistID] ON [Messages] ([ArtistID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181130095815_3')
BEGIN
    CREATE INDEX [IX_Messages_UserID] ON [Messages] ([UserID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181130095815_3')
BEGIN
    CREATE INDEX [IX_Messages_VenueID] ON [Messages] ([VenueID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181130095815_3')
BEGIN
    CREATE INDEX [IX_Shows_VenueID] ON [Shows] ([VenueID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181130095815_3')
BEGIN
    CREATE INDEX [IX_Venues_UserID] ON [Venues] ([UserID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181130095815_3')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181130095815_3', N'2.1.4-rtm-31024');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181130100232_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181130100232_Initial', N'2.1.4-rtm-31024');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202032119_4')
BEGIN
    ALTER TABLE [Artists] DROP CONSTRAINT [FK_Artists_Users_UserID];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202032119_4')
BEGIN
    ALTER TABLE [Venues] DROP CONSTRAINT [FK_Venues_Users_UserID];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202032119_4')
BEGIN
    DROP TABLE [Messages];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202032119_4')
BEGIN
    DROP TABLE [Users];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202032119_4')
BEGIN
    DROP INDEX [IX_Venues_UserID] ON [Venues];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202032119_4')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Venues]') AND [c].[name] = N'UserID');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Venues] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Venues] DROP COLUMN [UserID];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202032119_4')
BEGIN
    EXEC sp_rename N'[Artists].[UserID]', N'ShowID', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202032119_4')
BEGIN
    EXEC sp_rename N'[Artists].[IX_Artists_UserID]', N'IX_Artists_ShowID', N'INDEX';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202032119_4')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Venues]') AND [c].[name] = N'State');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Venues] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Venues] ALTER COLUMN [State] nvarchar(2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202032119_4')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Venues]') AND [c].[name] = N'Name');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Venues] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Venues] ALTER COLUMN [Name] nvarchar(50) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202032119_4')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Venues]') AND [c].[name] = N'City');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Venues] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [Venues] ALTER COLUMN [City] nvarchar(50) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202032119_4')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Venues]') AND [c].[name] = N'Address');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Venues] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [Venues] ALTER COLUMN [Address] nvarchar(50) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202032119_4')
BEGIN
    ALTER TABLE [Venues] ADD [Email] nvarchar(max) NOT NULL DEFAULT N'';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202032119_4')
BEGIN
    ALTER TABLE [Venues] ADD [Website] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202032119_4')
BEGIN
    ALTER TABLE [Shows] ADD [Description] nvarchar(300) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202032119_4')
BEGIN
    DECLARE @var5 sysname;
    SELECT @var5 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Artists]') AND [c].[name] = N'State');
    IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Artists] DROP CONSTRAINT [' + @var5 + '];');
    ALTER TABLE [Artists] ALTER COLUMN [State] nvarchar(2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202032119_4')
BEGIN
    DECLARE @var6 sysname;
    SELECT @var6 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Artists]') AND [c].[name] = N'Name');
    IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Artists] DROP CONSTRAINT [' + @var6 + '];');
    ALTER TABLE [Artists] ALTER COLUMN [Name] nvarchar(50) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202032119_4')
BEGIN
    DECLARE @var7 sysname;
    SELECT @var7 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Artists]') AND [c].[name] = N'Description');
    IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Artists] DROP CONSTRAINT [' + @var7 + '];');
    ALTER TABLE [Artists] ALTER COLUMN [Description] nvarchar(300) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202032119_4')
BEGIN
    DECLARE @var8 sysname;
    SELECT @var8 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Artists]') AND [c].[name] = N'City');
    IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Artists] DROP CONSTRAINT [' + @var8 + '];');
    ALTER TABLE [Artists] ALTER COLUMN [City] nvarchar(50) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202032119_4')
BEGIN
    ALTER TABLE [Artists] ADD [Email] nvarchar(max) NOT NULL DEFAULT N'';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202032119_4')
BEGIN
    ALTER TABLE [Artists] ADD CONSTRAINT [FK_Artists_Shows_ShowID] FOREIGN KEY ([ShowID]) REFERENCES [Shows] ([ShowID]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202032119_4')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181202032119_4', N'2.1.4-rtm-31024');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181203041932_9')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181203041932_9', N'2.1.4-rtm-31024');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181203044210_10')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181203044210_10', N'2.1.4-rtm-31024');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181203044828_11')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181203044828_11', N'2.1.4-rtm-31024');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181203065002_12')
BEGIN
    DECLARE @var9 sysname;
    SELECT @var9 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Artists]') AND [c].[name] = N'Email');
    IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [Artists] DROP CONSTRAINT [' + @var9 + '];');
    ALTER TABLE [Artists] ALTER COLUMN [Email] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181203065002_12')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181203065002_12', N'2.1.4-rtm-31024');
END;

GO

