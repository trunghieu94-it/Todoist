CREATE DATABASE TodoistDb
GO
USE TodoistDb
GO

CREATE TABLE Users
(
    Id INT IDENTITY(1,1) PRIMARY KEY,

    UserName NVARCHAR(50) NOT NULL,
    PasswordHash NVARCHAR(450) NOT NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),

    CONSTRAINT UQ_Users_UserName UNIQUE (UserName)
)
GO

CREATE TABLE TodoLists
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL,

    ListName NVARCHAR(100) NOT NULL,
    Deadline DATETIME2,
        
    ListPriority INT NOT NULL
        CONSTRAINT CK_TodoLists_Priority CHECK (ListPriority BETWEEN 1 AND 3),
        -- 1 = Low, 2 = Medium, 3 = High
    ListStatus INT NOT NULL
        CONSTRAINT CK_TodoLists_Status CHECK (ListStatus BETWEEN 1 AND 3),
        -- 1 = Active, 2 = Completed, 3 = Archieved
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    UpdatedAt DATETIME2 NULL,

    CONSTRAINT FK_TodoLists_Users
        FOREIGN KEY (UserId) REFERENCES Users(Id)
)
GO

CREATE TABLE TodoItems
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TodoListId INT NOT NULL,

    Title NVARCHAR(100) NOT NULL,
    ItemStatus INT NOT NULL
        CONSTRAINT CK_TodoItems_Status CHECK (ItemStatus BETWEEN 0 AND 1),
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    
    --Sau này mở rộng cho tương lai
    --Description NVARCHAR(MAX) NULL,
    --DueDate DATETIME2 NULL,
    --UpdatedAt DATETIME2 NULL,
    --OrderIndex INT NOT NULL DEFAULT(0)

    CONSTRAINT FK_TodoItems_TodoLists
        FOREIGN KEY (TodoListId) REFERENCES TodoLists(Id)
		ON DELETE CASCADE
)
GO

CREATE TABLE UserTodoLists
(
    UserId INT NOT NULL,
    TodoListId INT NOT NULL,

    UserRole INT NOT NULL
        CONSTRAINT CK_UserTodoLists_Role CHECK (UserRole BETWEEN 1 AND 3),
        -- 1 = Owner, 2 = Editor, 3 = Viewer
    CreatedAt DATETIME2 DEFAULT SYSDATETIME(),

    CONSTRAINT PK_UserTodoLists PRIMARY KEY(UserId, TodoListId),
    CONSTRAINT FK_UserTodoLists_Users
        FOREIGN KEY (UserId) REFERENCES Users(Id),
    CONSTRAINT FK_UserTodoLists_TodoLists
        FOREIGN KEY (TodoListId) REFERENCES TodoLists(Id)
		ON DELETE CASCADE
)
GO

CREATE TABLE Tags
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL,

    TagName NVARCHAR(100) NOT NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),

    CONSTRAINT UQ_Tags_User_TagName UNIQUE (UserId, TagName),
    CONSTRAINT FK_Tags_Users FOREIGN KEY (UserId) REFERENCES Users(Id)
)
GO

CREATE TABLE TodoListTags
(
    TodoListId INT NOT NULL,
    TagId INT NOT NULL,

    CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),

    CONSTRAINT PK_TodoListTags PRIMARY KEY (TodoListId, TagId),

    CONSTRAINT FK_TodoListTags_TodoLists
        FOREIGN KEY (TodoListId) REFERENCES TodoLists(Id)
		ON DELETE CASCADE,

    CONSTRAINT FK_TodoListTags_Tags
        FOREIGN KEY (TagId) REFERENCES Tags(Id)
)
GO

CREATE TABLE Notes
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TodoListId INT,
    UserId INT NOT NULL,

    Title NVARCHAR(100) NOT NULL,
    NoteContent NVARCHAR(MAX) NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    UpdatedAt DATETIME2 NULL,

    CONSTRAINT FK_Notes_TodoLists
        FOREIGN KEY (TodoListId) REFERENCES TodoLists(Id) ON DELETE SET NULL,

    CONSTRAINT FK_Notes_Users
        FOREIGN KEY (UserId) REFERENCES Users(Id)
)

-- Insert dữ liệu vào database
INSERT INTO Users (UserName, PasswordHash)
VALUES
    (N'trunghieu94', N'@hieuyeuHan76'),
    (N'quocdai', N'minhanh'),
    (N'admin', N'admin')
GO

INSERT INTO TodoLists(UserId, ListName, ListPriority, ListStatus, Deadline, CreatedAt,UpdatedAt)
VALUES
    (1, N'Ôn tập tiếng Anh chuyên ngành', 1, 1, '2026-06-30 10:00:00', '2026-02-10 16:40:44', NULL),
    (1, N'Kiến thức Backend C#', 2, 2, NULL,  '2026-02-10 16:47:44', NULL),
    (1, N'Phần mềm quản lý công việc cá nhân', 3, 3, '2026-04-09 15:30:00', '2026-02-10 16:41:42', NULL),
    (2, N'Chuẩn bị CV phỏng vấn', 1, 2, NULL, '2026-02-10 16:45:41', NULL),
    (2, N'Kiến thức thuật toán', 2, 1, NULL, '2026-02-10 16:40:42', NULL),
    (3, N'Tên dài để kiểm tra hiển thị UI', 3, 2, NULL, '2026-02-10 16:43:44', NULL),

	-- Priority 1
	(1, N'Học LINQ nâng cao',                1, 1, '2026-04-10 09:00:00', '2026-02-01 08:00:00', NULL),
	(1, N'Đọc tài liệu ASP.NET Core',        1, 2, NULL,                  '2026-02-02 09:15:00', NULL),
	(1, N'Luyện code LeetCode',              1, 3, '2026-04-15 20:00:00', '2026-02-03 10:30:00', NULL),

	-- Priority 2
	(1, N'Xây dựng RESTful API',             2, 1, NULL,                  '2026-02-04 11:00:00', NULL),
	(1, N'Học Entity Framework Core',        2, 2, '2026-05-01 14:00:00', '2026-02-05 13:20:00', NULL),
	(1, N'Tối ưu query SQL',                 2, 3, NULL,                  '2026-02-06 15:45:00', NULL),

	-- Priority 3
	(1, N'Thiết kế UI cho app Todo',         3, 1, '2026-04-20 18:00:00', '2026-02-07 16:00:00', NULL),
	(1, N'Học design pattern',               3, 2, NULL,                  '2026-02-08 17:10:00', NULL),
	(1, N'Viết unit test cho project',       3, 3, '2026-04-25 21:30:00', '2026-02-09 18:25:00', NULL),

	-- Extra để test nhiều hơn (mix đủ điều kiện)
	(1, N'Refactor code cũ',                 1, 2, NULL,                  '2026-02-10 08:45:00', NULL),
	(1, N'Tìm hiểu Clean Architecture',      2, 1, '2026-05-10 10:00:00', '2026-02-11 09:30:00', NULL),
	(1, N'Triển khai Redis cache',           3, 3, NULL,                  '2026-02-12 11:15:00', NULL);
GO

INSERT INTO TodoItems(TodoListId, Title, ItemStatus)
VALUES
    (1, N'Học chương 1', 1),
    (1, N'Học chương 2', 0),
    (3, N'Thiết kế Database', 1),
    (3, N'Xây dựng API', 0),
    (3, N'Thiết kế giao diện', 0),
    (5, N'Các thuật toán tìm kiếm', 1),
    (5, N'Các thuật toán sắp xếp', 0),
    (6, N'Cho một cái tên thật dài chỉ để kiểm tra UI hiển thị như thế nào', 1)
GO

INSERT INTO Notes(UserId, TodoListId, Title, NoteContent, UpdatedAt)
VALUES
    (1, NULL, N'Note 1', N'Nội dung cho Note 1', NULL),
    (1, 1, N'Note 2', N'Nội dung cho Note 2', NULL),
    (2, NULL, N'Note 3', N'Nội dung cho Note 3', NULL),
    (2, 3, N'Note 4', N'Nội dung cho Note 4', NULL),
    (2, 4, N'Note 5', N'Nội dung cho Note 5', NULL)
GO

INSERT INTO Tags(UserId, TagName)
VALUES
    (1, N'Học tập'),
    (1, N'Công việc'),
    (1, N'Cá nhân'),
    (2, N'Công việc'),
    (2, N'Học tập'),
    (2, N'Cuộc sống')
GO

INSERT INTO UserTodoLists(UserId, TodoListId, UserRole)
VALUES
    (1, 1, 1),
    (1, 2, 1),
    (1, 3, 1),
    (1, 4, 2),
    (1, 5, 3),
    (2, 4, 1),
    (2, 5, 1),
    (2, 1, 2),
    (2, 2, 3),
    (3, 4, 2),
    (3, 5, 3)
GO

INSERT INTO TodoListTags (TodoListId, TagId)
VALUES
    (1, 1),
    (2, 2),
    (3, 3),
    (4, 4),
    (5, 5)
GO

-- Xóa dữ liệu bảng
--DELETE FROM TodoListTags
--DELETE FROM UserTodoLists
--DELETE FROM Notes
--DELETE FROM Tags
--DELETE FROM TodoItems
--DELETE FROM TodoLists
--DELETE FROM Users

-- Reset Id nếu cần
--DBCC CHECKIDENT ('Notes', RESEED, 0)
--DBCC CHECKIDENT ('Tags', RESEED, 0)
--DBCC CHECKIDENT ('TodoItems', RESEED, 8)
--DBCC CHECKIDENT ('TodoLists', RESEED, 18)
--DBCC CHECKIDENT ('Users', RESEED, 0)
--GO


