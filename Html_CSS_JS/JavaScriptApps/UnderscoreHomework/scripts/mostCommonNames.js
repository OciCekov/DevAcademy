define(["underscore", "collections"], function (_, collections) {
    var students,
        collectionToReturn,
        firstName,
        lastName,
        firstNameCount,
        firstNameResult,
        lastNameResult,
        lastNameCount;
    students = collections.students;
    firstName = _.countBy(students, "fname");
    firstNameCount = _.max(firstName);
    lastName = _.countBy(students, "lname");
    lastNameCount = _.max(lastName);
    firstNameResult = _.invert(firstName)[firstNameCount];
    lastNameResult = _.invert(lastName) [lastNameCount];
    collectionToReturn = "First name: " + firstNameResult + "<br>" + "Last name: " + lastNameResult;

    return collectionToReturn;
});
