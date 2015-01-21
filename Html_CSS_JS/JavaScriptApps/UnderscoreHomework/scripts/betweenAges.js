define(["underscore", "collections"], function (_, collections) {
    var students,
        collectionToReturn,
        maxAge,
        minAge,
        result;
    students = collections.students;
    collectionToReturn = String();
    maxAge = 24;
    minAge = 18;

    result = _.filter(students, function (student) {
        return student.age >= minAge && student.age <= maxAge;
    });
    _.each(result, function (student) {
        collectionToReturn += student.fname + " " + student.lname + ": " + student.age + "<br>";
    });
    return collectionToReturn;

});