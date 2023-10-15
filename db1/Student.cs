﻿namespace db1;
/*
 В библиотеке есть книги за чьим-то авторством, названием и годом издания.
 Также у книги известно, в шкафу с каким номером и на какой полке она стоит.
 Книги могут брать читатели, о которым известно их ФИО и уникальный номер читательского билета.
 Известно кто какую книгу когда взял и когда вернул.
*/
public class Student
{
    public required string FirstName { get; set; }
    public required string SecondName { get; set; }
    public string? FatherName { get; set; }
    public required Guid Id_Student   { get; set; }
}