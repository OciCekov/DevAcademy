define(["underscore", "collections"], function (_, collections) {
    var students,
        collectionToReturn,
        bestStudent;
    students = collections.students;
    bestStudent = _.max(students, function (student) {
        return student.averageMarks;
    });
    collectionToReturn = bestStudent.fname + " " + bestStudent.lname + ": " + bestStudent.averageMarks + "<br>";
    return collectionToReturn;
});