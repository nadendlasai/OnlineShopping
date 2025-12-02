create database OnlineShopping

--create schema Auth;

if not exists(select * from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA='Auth' and TABLE_NAME='Users')
begin
create table Auth.Users
(
[Id]               uniqueidentifier      not null,
[Email]            nvarchar(256)         not null unique,
[UserName]         nvarchar(256)         not null,
[PasswordHash]     nvarchar(max)         not null,
[CreatedAt]        datetime2(7)          not null   default sysutcdatetime(),
[IsActive]         bit                   not null   default 1,
CONSTRAINT [PK_Users_Id] PRIMARY KEY CLUSTERED ([Id] ASC))
end