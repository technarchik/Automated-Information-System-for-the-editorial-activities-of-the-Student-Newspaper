SELECT ID_spec,Login,Password FROM Member WHERE Login = 'Viktoriya'
select * from Position
insert into Member (ID_spec, ID_position, Surname, Name, Patronymic, Birthday, Link_VK, Date_of_taking, Scholarship, Login, Password) 
values (2, 5, 'Пировских', 'Виктория', 'Николаевна', '26/02/2001', 'https://vk.com/pirotechvika', '01/02/2020', '11000', 'Viktoriya', '123')

insert into Member (ID_spec, ID_position, Surname, Name, Patronymic, Birthday, Link_VK, Date_of_taking, Scholarship, Login, Password) 
values (1, 5, 'Горохова', 'Анастасия', 'Григорьевна', '04/11/2001', 'https://vk.com/pirotechvika', '02/07/2020', '9000', 'Nastya', '123')

insert into Member (ID_spec, ID_position, Surname, Name, Patronymic, Birthday, Link_VK, Date_of_taking, Scholarship, Login, Password) 
values (2, 4, 'Петров', 'Аркадий', 'Васильевич', '13/10/2000', 'https://vk.com/pirotechvika', '09/11/2018', '12000', 'Arkadiy', '123')

insert into Member (ID_spec, ID_position, Surname, Name, Patronymic, Birthday, Link_VK, Date_of_taking, Scholarship, Login, Password) 
values (1, 3, 'Иванов', 'Николай', 'Петрович', '19/10/2000', 'https://vk.com/pirotechvika', '09/11/2019', '14000', 'Nikolai', '123')

insert into Member (ID_spec, ID_position, Surname, Name, Patronymic, Birthday, Link_VK, Date_of_taking, Scholarship, Login, Password) 
values (1, 2, 'Николаева', 'Мария', 'Алексеевна', '04/03/1999', 'https://vk.com/pirotechvika', '09/11/2016', '17000', 'Mariya', '123')

insert into Member (ID_spec, ID_position, Surname, Name, Patronymic, Birthday, Link_VK, Date_of_taking, Scholarship, Login, Password) 
values (1, 1, 'Зубенко', 'Михаил', 'Петрович', '10/05/1998', 'https://vk.com/pirotechvika', '09/11/2015', '20000', 'Michail', '123')

insert into Member (ID_spec, ID_position, Surname, Name, Patronymic, Birthday, Link_VK, Date_of_taking, Scholarship, Login, Password) 
values (2, 5, 'Потапова', 'Алина', 'Васильевна', '10/07/2002', 'https://vk.com/pirotechvika', '11/05/2015', '10000', 'Alina', '123')

insert into Member (ID_spec, ID_position, Surname, Name, Patronymic, Birthday, Link_VK, Date_of_taking, Scholarship, Login, Password) 
values (1, 5, 'Миронов', 'Петр', 'Петрович', '11/06/2000', 'https://vk.com/pirotechvika', '01/10/2015', '10000', 'Petr', '123')


insert into Position values ('Шеф-редактор') 1
insert into Position values ('Выпускающий редактор') 2
insert into Position values ('Редактор номера') 3
insert into Position values ('Бильд-редактор') 4
insert into Position values ('Участник') 5

update Member set ID_spec = 1 where ID_member = 4

insert into Status (Status_name) values ('Пишется')
insert into Status (Status_name) values ('На проверку')
insert into Status (Status_name) values ('На верстку')
insert into Status (Status_name) values ('На заключительную проверку')
insert into Status (Status_name) values ('Готово к печати')

insert into Material (ID_status, Header, N_page, Deadline_write, Deadline_design) values (1, 'Новый год', 2, '24/12/2022', '28/12/2022')
insert into Material (ID_status, Header, N_page, Deadline_write, Deadline_design) values (2, 'Символ года', 5, '26/12/2022', '29/12/2022')
insert into Material (ID_status, Header, N_page, Deadline_write, Deadline_design) values (3, 'Рецепты для праздничного стола', 4, '25/12/2022', '28/12/2022')
insert into Material (ID_status, Header, N_page, Deadline_write, Deadline_design) values (4, 'Дизайн стикеров', 3, '26/12/2022', '29/12/2022')
insert into Material (ID_status, Header, N_page, Deadline_write, Deadline_design) values (5, 'Последние разработки инженерного гаража', 7, '27/12/2022', '30/12/2022')

insert into Comment (ID_material, ID_author, Short_descr, Long_descr) values (3, 4, 'Свои фото, цветовая гамма - синяя', 'Пришлю свои фотографии, хочется оформить в зимнем стиле, добавить снежинок, фон желательно полностью светло-синий')
insert into Comment (ID_material, ID_author, Short_descr, Long_descr) values (7, 5, 'Короткий коммент', 'Длинный коммент')

insert into Creates (ID_member, ID_material) values (2,3) --Я верстаю сейчас этот текст
insert into Creates (ID_member, ID_material) values (4,1) --Горохова пишет сейчас этот текст
insert into Creates (ID_member, ID_material) values (4,3) --Горохова писала этот текст
insert into Creates (ID_member, ID_material) values (2, 7)

insert into Resourse values (3, 'https://docs.google.com/document/d/13L4viDlWvKmlh4BzyG3-uJWf_X9s-KbIaJWJxUcv-3s/edit?usp=share_link')
insert into Resourse values (1, 'https://docs.google.com/document/d/1L-4dnEaErN4kOtQuwofiR1kV72NV1LuqSqmziYjXoII/edit?usp=share_link')

insert into Specialization (Spec_name) values ('Журналист')
insert into Specialization (Spec_name) values ('Верстальщик')







-------------------------------------------------------------------------------------------------------------------------------------------------------
--форма ЛК
--процедура выбора названия статьи
create proc SelectHeaders (@ID_member int)
as
declare @ID_spec int
declare @ID_position int
select @ID_spec = ID_spec, @ID_position = ID_position from Member where ID_member = @ID_member
begin
	if (@ID_spec = 1 and @ID_position = 5) --статус 1
		select Material.ID_material, Header from Creates, Material, Status
		where Creates.ID_material = Material.ID_material and Material.ID_status = Status.ID_status 
		and Status.ID_status = 1 and ID_member = @ID_member
	if (@ID_spec = 2 and @ID_position = 5) --статус 3
		select Material.ID_material, Header from Creates, Material, Status
		where Creates.ID_material = Material.ID_material and Material.ID_status = Status.ID_status 
		and Status.ID_status = 3 and ID_member = @ID_member
	else if (@ID_spec = 1 and @ID_position = 3) --статус 2
		select Material.ID_material, Header from Material, Status
		where Material.ID_status = Status.ID_status and Status.ID_status = 2
	else if ((@ID_spec = 1 and @ID_position = 2) or (@ID_spec = 2 and @ID_position = 4)) --статус 4
		select Material.ID_material, Header from Material, Status
		where Material.ID_status = Status.ID_status and Status.ID_status = 4
	else if (@ID_spec = 1 and @ID_position = 1) --статус 5
		select Material.ID_material, Header from Material, Status
		where Material.ID_status = Status.ID_status and Status.ID_status = 5
	else return null
end

-- процедура возврата дедлайна
create proc SelectDeadline @ID_material int, @ID_member int
as
declare @ID_spec int
select @ID_spec = ID_spec from Member where ID_member = @ID_member
begin
	if (@ID_spec = 1)
		select Deadline_write from Material where ID_material = @ID_material 
	else if (@ID_spec = 2)
		select Deadline_design from Material where ID_material = @ID_material
	else return null
end

-- процедура изменения статуса
create proc ChangeStatus @ID_material int
as
declare @ID_status int
select @ID_status = ID_status from Material where @ID_material = ID_material
begin
	if (@ID_status < 5)
		update Material set ID_status = ID_status + 1 where @ID_material = ID_material
	else if (@ID_status >= 5)
		update Material set ID_status = 5 where @ID_material = ID_material
end

-- процедура изменения статуса - откат назад
create proc ChangeStatusBack @ID_material int
as
declare @ID_status int
select @ID_status = ID_status from Material where @ID_material = ID_material
begin
	if (@ID_status > 1)
		update Material set ID_status = ID_status - 1 where @ID_material = ID_material
	else if (@ID_status <= 1)
		update Material set ID_status = 1 where @ID_material = ID_material
end

--процедура возврата ссылки на ресурс
create proc SelectLink @ID_material int
as
select Link from Resourse where ID_material = @ID_material 

-- процедура возврата комментариев
create proc SelectComments @ID_material int, @ID_member int
as
declare @ID_position_member int, @ID_position_author int
select @ID_position_member = ID_position from Member where ID_member = @ID_member --ищу позицию того, кому нужен коммент
select @ID_position_author = ID_position from Member, Creates, Material, Comment --ищу позицию того, кто оставил коммент
	where Member.ID_member = Creates.ID_member and Creates.ID_material = Material.ID_material 
	and Material.ID_material = Comment.ID_material and Member.ID_member = ID_author
begin
	if (@ID_position_author = 5 and @ID_position_member = 5)
		select Short_descr, Long_descr from Comment where ID_material = @ID_material
	else if (@ID_position_author > @ID_position_member)
		select Short_descr, Long_descr from Comment where ID_material = @ID_material
end


--форма редактирования материала - окно 1
--процедура заполнения формы редактирования
create proc EditFormAdding @ID_material int
as
select Header, N_page, Deadline_write, Deadline_design, Link from Material, Resourse 
where Resourse.ID_material = Material.ID_material and Material.ID_material = @ID_material

-- процедура обновления материала
create proc UpdateMaterial @ID_material int, @Link nvarchar(1024), @Header nvarchar(1024), @N_page int, @Deadline_write date, @Deadline_design date
as
begin
	update Material set Header = @Header, N_page = @N_page, Deadline_write = @Deadline_write, Deadline_design = @Deadline_design
	where ID_material = @ID_material
	update Resourse set Link = @Link
	where ID_material = @ID_material
end

-- процедура создания материала
create proc AddMaterial @Header nvarchar(1024), @N_page int, @Deadline_write date, @Deadline_design date
as
begin
	insert into Material (ID_status, Header, N_page, Deadline_write, Deadline_design) values (1, @Header, @N_page, @Deadline_write, @Deadline_design)
end

-- процедура получения ID только что созданного материала
create proc LastMaterial
as
select max(ID_material) from Material

--форма редактирования материала - окно 2
-- процедура возврата ответственных за материал
create proc MembersDoMaterial @ID_material int, @ID_spec int
as
begin
	select Creates.ID_member, Surname, Name, Patronymic from Creates, Member
	where Creates.ID_member = Member.ID_member and ID_material = @ID_material and ID_spec = @ID_spec
end

--------------------------------------------------------------------------------------------------------------------------------------------------------


--триггер на удаление из бд материала, который привязан в creates
create trigger DeleteMaterial
on Material
instead of delete
as
	delete from Creates where ID_material in (select d.ID_material from deleted d)
	delete from Comment where ID_material in (select d.ID_material from deleted d)
	delete from Material where ID_material in (select d.ID_material from deleted d)

--триггер на удаление из бд участника, который привязан в creates
create trigger DeleteMember
on Member
instead of delete
as
	delete from Creates where ID_member in (select d.ID_member from deleted d)
	delete from Member where ID_member in (select d.ID_member from deleted d)

--триггер на совпадение логинов
create trigger EqualLogins
on Member
instead of insert
as
	if exists (select Login from Member
				where Login in (select Login from inserted))
				print 'Такой логин уже есть'
	else insert into Member select i.ID_spec, i.ID_position, i.Surname, i.Name, i.Patronymic, i.Birthday, i.Link_VK, i.Date_of_taking, i.Scholarship, i.Login, i.Password from inserted i

-- ограничение целостности
ALTER TABLE Material WITH NOCHECK
add check (Deadline_write >= GETDATE())

ALTER TABLE Material WITH NOCHECK
add check (Deadline_design >= GETDATE())

ALTER TABLE Member WITH NOCHECK
add check (Date_Of_Taking >= '01/09/1999')






