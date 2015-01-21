(function () {
    require.config({
        paths: {
            'jquery': "libs/jquery.min",
            'httpRequester': "httpRequester/httpRequester"
        }
    });


    require(['httpRequester', 'jquery'], function (request, $) {
        var delay = 1000,
            fade = 1000;

        function showStudent(student) {
            var $tr = $('<tr/>'),
                $td = $('<td/>'),
                $row;
            $row = $tr.clone();
            $td.clone().html(student.id).addClass('students-id').appendTo($row);
            $td.clone().html(student.name).appendTo($row);
            $td.clone().html(student.grade).appendTo($row);
            $('table').append($row);
        }

        function displayAll() {
            $("table").find("tr:gt(0)").remove();
            request.getJSON('http://localhost:3000/students ', 'application/json')
                .then(function (data) {
                    var i;
                    for (i = 0; i < data.students.length; i++) {
                        showStudent(data.students[i]);
                    }
                }, function (error) {
                    $('#error').html(error.responseText);
                });

        }

        function addStudent() {
            var name = $('#lname').val(),
                grade = $('#grade').val(),
                student = {
                    name: name,
                    grade: grade
                };
            if (!name) {
                $('#error').html("Student's name must be at least 2 characters long.")
                    .show().fadeOut(fade);
                return;
            }

            if (!grade) {
                $('#error').html("Student's grade must be number")
                    .show().fadeOut(fade);
                return;
            }

            request.postJSON('http://localhost:3000/students ', 'application/json', student)
                .then(function () {
                    $('#success').html('Student ' + student.name + ' successfully added.')
                        .show().fadeOut(fade);
                    displayAll();
                }, function (error) {
                    $('#error').html('Student was not added due to error.')
                        .show().fadeOut(fade);
                });
        }

        function deleteStudent() {
            var id = $('#student-id').val();
            if (!idValidation(id)) {
                $('#error').html("Id " + id + " was not found.")
                    .show().fadeOut(fade);
                return;
            }
            request.postJSON('http://localhost:3000/students/' + id + '/')
                .then(function () {
                    $('#success').html('Student with id ' + id + ' successfully deleted.')
                        .show().fadeOut(fade);
                    displayAll();
                }, function (error) {
                    $('#error').html('something terrible happened')
                        .show().fadeOut(fade);
                });
        }

        function idValidation(id) {
            var elements = $('.students-id');
            console.log(elements);
            for (var i = 0; i < elements.length; i++) {
                if (elements[i].textContent === id) {
                    return true;
                }
            }
            return false;
        }

        displayAll();

        $('#add-btn').click(function () {
            addStudent();
        });

        $('#delete-btn').click(function () {
            deleteStudent();
        });

    });
}());


