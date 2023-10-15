namespace db1;
/*
 В библиотеке есть книги за чьим-то авторством, названием и годом издания.
 Также у книги известно, в шкафу с каким номером и на какой полке она стоит.
 Книги могут брать читатели, о которым известно их ФИО и уникальный номер читательского билета.
 Известно кто какую книгу когда взял и когда вернул.
*/
public class Statistic
{
    public Guid Id { get; set; }
    public Student Id_Student { get; set; }
    public Book Id_Book { get; set; }
    public DateOnly TakeDateOnly { get; set; }
    public DateOnly ReturnDateOnly { get; set; }
}