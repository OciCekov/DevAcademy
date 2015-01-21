define(["collections", "underscore"], function (collections, _) {

        var students = collections.students;
        var collectionToReturn = new String();
        var result = _.filter(students, function (student) {
            return student.fname > student.lname
        })
        _.sortBy(students, function (student) {
            student.fname + student.lname
        })
        _.each(result.reverse(), function (student) {
            collectionToReturn += student.fname + " " + student.lname + " <br> "
        });

        return collectionToReturn;
    }
);