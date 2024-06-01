/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     18.12.2022 12:20:04                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Comment') and o.name = 'FK_COMMENT_MAY_HAVE_MATERIAL')
alter table Comment
   drop constraint FK_COMMENT_MAY_HAVE_MATERIAL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Creates') and o.name = 'FK_CREATES_CREATES_MEMBER')
alter table Creates
   drop constraint FK_CREATES_CREATES_MEMBER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Creates') and o.name = 'FK_CREATES_CREATES2_MATERIAL')
alter table Creates
   drop constraint FK_CREATES_CREATES2_MATERIAL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Material') and o.name = 'FK_MATERIAL_IS_IN_STATUS')
alter table Material
   drop constraint FK_MATERIAL_IS_IN_STATUS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Member') and o.name = 'FK_MEMBER_HOLD_POSITION')
alter table Member
   drop constraint FK_MEMBER_HOLD_POSITION
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Member') and o.name = 'FK_MEMBER_POSSESSE_SPECIALI')
alter table Member
   drop constraint FK_MEMBER_POSSESSE_SPECIALI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Resourse') and o.name = 'FK_RESOURSE_HAVE_MATERIAL')
alter table Resourse
   drop constraint FK_RESOURSE_HAVE_MATERIAL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Comment')
            and   name  = 'May_have_FK'
            and   indid > 0
            and   indid < 255)
   drop index Comment.May_have_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Comment')
            and   type = 'U')
   drop table Comment
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Creates')
            and   name  = 'Creates2_FK'
            and   indid > 0
            and   indid < 255)
   drop index Creates.Creates2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Creates')
            and   name  = 'Creates_FK'
            and   indid > 0
            and   indid < 255)
   drop index Creates.Creates_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Creates')
            and   type = 'U')
   drop table Creates
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Material')
            and   name  = 'Is_in_FK'
            and   indid > 0
            and   indid < 255)
   drop index Material.Is_in_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Material')
            and   type = 'U')
   drop table Material
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Member')
            and   name  = 'Hold_FK'
            and   indid > 0
            and   indid < 255)
   drop index Member.Hold_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Member')
            and   name  = 'Possesse_FK'
            and   indid > 0
            and   indid < 255)
   drop index Member.Possesse_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Member')
            and   type = 'U')
   drop table Member
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Position')
            and   type = 'U')
   drop table Position
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Resourse')
            and   name  = 'Have_FK'
            and   indid > 0
            and   indid < 255)
   drop index Resourse.Have_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Resourse')
            and   type = 'U')
   drop table Resourse
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Specialization')
            and   type = 'U')
   drop table Specialization
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Status')
            and   type = 'U')
   drop table Status
go

/*==============================================================*/
/* Table: Comment                                               */
/*==============================================================*/
create table Comment (
   ID_comment           int                  not null,
   ID_material          int                  not null,
   ID_author            int                  not null,
   Short_descr          nvarchar(1024)       not null,
   Long_descr           nvarchar(1024)       null,
   constraint PK_COMMENT primary key (ID_comment)
)
go

/*==============================================================*/
/* Index: May_have_FK                                           */
/*==============================================================*/




create nonclustered index May_have_FK on Comment (ID_material ASC)
go

/*==============================================================*/
/* Table: Creates                                               */
/*==============================================================*/
create table Creates (
   ID_member            int                  not null,
   ID_material          int                  not null,
   constraint PK_CREATES primary key (ID_member, ID_material)
)
go

/*==============================================================*/
/* Index: Creates_FK                                            */
/*==============================================================*/




create nonclustered index Creates_FK on Creates (ID_member ASC)
go

/*==============================================================*/
/* Index: Creates2_FK                                           */
/*==============================================================*/




create nonclustered index Creates2_FK on Creates (ID_material ASC)
go

/*==============================================================*/
/* Table: Material                                              */
/*==============================================================*/
create table Material (
   ID_material          int                  not null,
   ID_status            int                  null,
   Header               nvarchar(1024)       not null,
   N_page               tinyint              null,
   Deadline_write       datetime             not null,
   Deadline_design      datetime             not null,
   constraint PK_MATERIAL primary key (ID_material)
)
go

/*==============================================================*/
/* Index: Is_in_FK                                              */
/*==============================================================*/




create nonclustered index Is_in_FK on Material (ID_status ASC)
go

/*==============================================================*/
/* Table: Member                                                */
/*==============================================================*/
create table Member (
   ID_member            int                  not null,
   ID_spec              int                  null,
   ID_position          int                  not null,
   Surname              nvarchar(1024)       not null,
   Name                 nvarchar(1024)       not null,
   Patronymic           nvarchar(1024)       not null,
   Birthday             datetime             null,
   Link_VK              nvarchar(1024)       not null,
   Date_of_taking       datetime             null,
   Scholarship          decimal(38)          not null,
   constraint PK_MEMBER primary key (ID_member)
)
go

/*==============================================================*/
/* Index: Possesse_FK                                           */
/*==============================================================*/




create nonclustered index Possesse_FK on Member (ID_spec ASC)
go

/*==============================================================*/
/* Index: Hold_FK                                               */
/*==============================================================*/




create nonclustered index Hold_FK on Member (ID_position ASC)
go

/*==============================================================*/
/* Table: Position                                              */
/*==============================================================*/
create table Position (
   ID_position          int                  not null,
   Position_name        nvarchar(1024)       not null,
   constraint PK_POSITION primary key (ID_position)
)
go

/*==============================================================*/
/* Table: Resourse                                              */
/*==============================================================*/
create table Resourse (
   ID_resourse          int                  not null,
   ID_material          int                  null,
   Link                 nvarchar(1024)       not null,
   constraint PK_RESOURSE primary key (ID_resourse)
)
go

/*==============================================================*/
/* Index: Have_FK                                               */
/*==============================================================*/




create nonclustered index Have_FK on Resourse (ID_material ASC)
go

/*==============================================================*/
/* Table: Specialization                                        */
/*==============================================================*/
create table Specialization (
   ID_spec              int                  not null,
   Spec_name            nvarchar(1024)       not null,
   constraint PK_SPECIALIZATION primary key (ID_spec)
)
go

/*==============================================================*/
/* Table: Status                                                */
/*==============================================================*/
create table Status (
   ID_status            int                  not null,
   Status_name          nvarchar(1024)       not null,
   constraint PK_STATUS primary key (ID_status)
)
go

alter table Comment
   add constraint FK_COMMENT_MAY_HAVE_MATERIAL foreign key (ID_material)
      references Material (ID_material)
go

alter table Creates
   add constraint FK_CREATES_CREATES_MEMBER foreign key (ID_member)
      references Member (ID_member)
go

alter table Creates
   add constraint FK_CREATES_CREATES2_MATERIAL foreign key (ID_material)
      references Material (ID_material)
go

alter table Material
   add constraint FK_MATERIAL_IS_IN_STATUS foreign key (ID_status)
      references Status (ID_status)
go

alter table Member
   add constraint FK_MEMBER_HOLD_POSITION foreign key (ID_position)
      references Position (ID_position)
go

alter table Member
   add constraint FK_MEMBER_POSSESSE_SPECIALI foreign key (ID_spec)
      references Specialization (ID_spec)
go

alter table Resourse
   add constraint FK_RESOURSE_HAVE_MATERIAL foreign key (ID_material)
      references Material (ID_material)
go

