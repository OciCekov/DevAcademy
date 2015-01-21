define(["underscore", "collections"], function (_, collections) {
    var books,
        result,
        count,
        collectionToReturn = String;
    books = collections.books;
    result = _.countBy(books, "author")
    count = _.max(result);
    collectionToReturn = _.invert(result)[count];

    return collectionToReturn;
});
