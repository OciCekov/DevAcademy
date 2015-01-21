(function () {
    var number = 0,
        score = 0,
        cows = 0,
        bulls = 0;

    function getRandomNumber() {
        var min = 1000;
        var max = 9999;
        var number = Math.floor(Math.random() * (max - min + 1)) + min;
        console.log(number); // Just to make it a little bit easyer :)
        return number.toString();
    }

    function startGame() {
        $('#play-btn').hide();
        $('#number-container').show();
        $('#msg').text('Напиши си числото');
        $('#number').val('');
        $('#name').val('');
        number = getRandomNumber();
        while (digitRepeat(number)) {
            number = getRandomNumber();
        }
    }

    function digitRepeat(num) {
        var count = 0,
            numAsString = num.toString(),
            digitIndex;

        for (var i = 0; i < 4; i++) {
            digitIndex = numAsString.indexOf(numAsString[i].toString());

            while (digitIndex !== -1) {
                count++;
                digitIndex = numAsString.indexOf(numAsString[i], digitIndex + 1);
            }
            if (count > 1) {
                return true;
            }
            count = 0;
        }
        return false;
    }

    function checkNumber() {
        var value = $('#number').val(),
            $cow = $('#cows'),
            $bull = $('#bulls');
        bulls = getBulls(value);
        cows = getCows(value);

        if (value < 1000 || value > 9999) {
            $('#msg').text('Грешен брой цифри!');
            $cow.text('');
            $bull.text('');
            return;
        }
        else if (!isFinite(value)) {
            $('#msg').text('Само цифри!');
            $cow.text('');
            $bull.text('');
            return;
        }
        else if (digitRepeat(value)) {
            $('#msg').text('Само различни цифри');
            $cow.text('');
            $bull.text('');
            return;
        }
        else {
            $('#msg').text('Въведи име');
        }

        $cow.text("Крави: " + cows);
        $bull.text("Бикове: " + bulls);

        if (bulls === 4) {
            $('#number-container').hide();
            $('#name-container').show();
        }
        score += 1;
    }


    function getCows(value) {
        var cowCount = 0;
        for (var i = 0; i < value.length; i++) {
            if (value[i] !== number[i] && value.indexOf(number[i]) !== -1) {
                if (bulls === 3) {
                    continue;
                }
                cowCount++;
            }
        }
        return cowCount;
    }

    function getBulls(value) {
        var bullsCount = 0;
        for (var i = 0; i < value.length; i++) {
            if (value[i] === number[i]) {
                bullsCount++;
            }
        }
        return bullsCount;
    }

    function saveScore() {
        var name = $('#name').val();

        if (name.length <= 1) {
            $('#msg').text('Грешно име');
            return;
        }
        localStorage.setItem(name, score);
        score = 0;
        $('#name-container').hide();
        $('#play-btn').show();
        name = '';
        $('#number').val('');
        $('#cows').text("Крави: 0");
        $('#bulls').text("Бикове: 0");
        loadScore();
    }

    function loadScore() {
        var highscores = [],
            list = [];

        for (var i = 0; i < localStorage.length; i++) {
            var nickName = localStorage.key(i),
                score = localStorage.getItem(nickName);

            highscores.push([nickName, score]);
        }

        highscores.sort(function (a, b) {
            a = parseInt(a[1]);
            b = parseInt(b[1]);

            return a < b ? -1 : (a > b ? 1 : 0);
        });

        var count = 1;
        for (var player in highscores) {
            list.push(count + '. ' + highscores[player][0] + ' - ' + highscores[player][1] + ' опити.');
            count++;
        }
        $('#scores').html(list.join('<br/>'));
    }

    function bindEvents() {
        $('#play-btn').click(function () {
            startGame();
        });

        $('#check-btn').click(function () {
            checkNumber();
        });

        $('#submit-btn').click(function () {
            saveScore()
        });
        $('#clear-btn').click(function () {
            localStorage.clear();
            loadScore();
        });
    }

    $(document).ready(function () {
        loadScore();
        bindEvents();
    });
}());


