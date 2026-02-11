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
        -- 1 = Active, 2 = Completed, 3 = Archived
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
        FOREIGN KEY (TodoListId) REFERENCES TodoLists(Id),

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

INSERT INTO TodoLists(UserId, ListName, ListPriority, ListStatus, Deadline, UpdatedAt)
VALUES
    (1, N'Ôn tập tiếng Anh chuyên ngành', 1, 1, NULL, NULL),
    (1, N'Kiến thức Backend C#', 2, 2, NULL, NULL),
    (1, N'Phần mềm quản lý công việc cá nhân', 3, 3, NULL, NULL),
    (2, N'Chuẩn bị CV phỏng vấn', 1, 2, NULL, NULL),
    (2, N'Kiến thức thuật toán', 2, 1, NULL, NULL),
    (3, N'Tên dài để kiểm tra hiển thị UI', 3, 2, NULL, NULL)
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
    (2, 3, N'Note 5', N'Nội dung cho Note 5', NULL)
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

SELECT * FROM TodoLists

-- Xóa dữ liệu bảng
DELETE FROM TodoListTags
DELETE FROM UserTodoLists
DELETE FROM Notes
DELETE FROM Tags
DELETE FROM TodoItems
DELETE FROM TodoLists
DELETE FROM Users

-- Reset Id nếu cần
DBCC CHECKIDENT ('Notes', RESEED, 0)
DBCC CHECKIDENT ('Tags', RESEED, 0)
DBCC CHECKIDENT ('TodoItems', RESEED, 0)
DBCC CHECKIDENT ('TodoLists', RESEED, 6)
DBCC CHECKIDENT ('Users', RESEED, 0)
GO
