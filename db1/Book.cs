namespace db1;
/*
 В библиотеке есть книги за чьим-то авторством, названием и годом издания.
 Также у книги известно, в шкафу с каким номером и на какой полке она стоит.
 Книги могут брать читатели, о которым известно их ФИО и уникальный номер читательского билета.
 Известно кто какую книгу когда взял и когда вернул.
*/
public class Book
{
 public required Guid Id_Book { get; set; }
 public required string Author { get; set; }
 public required string Name { get; set; }
 public required DateOnly PublicationDate { get; set; }
 public required uint BookCaseNumber { get; set; }
 public required uint ShelfNumber { get; set; }
}