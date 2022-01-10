let BooksArray = [];

var BookStore = {

    dataSubmit: () => {
        debugger;
        let bookObject = {
            bookName: $("#bookName").val(),
            isbn: $("#ISBNnum").val(),
            author: $("#author").val(),
            price: $("#price").val()
        };

        BooksArray.push(bookObject);

        $.ajax({
            type: "POST",
            contentType: 'application/json; charset=utf-8',
            url: "/Main/BookRegister/",
            dataType: "json",
            data: JSON.stringify({ "bookObject": BooksArray }),
            success: (data) => {
                console.log(data);
            }
        });
    }
}