define(function () {
    var objects;
    objects = (function () {
        var Food,

            Snake = (function () {
                function Snake() {
                    this.bodyLenght = 5;
                    this.bodySegment = 20;
                    this.direction = 0;
                    this._body = [];
                    this._forClear = {};
                }

                Snake.prototype.head = function () {
                    return this._body[0];
                };

                Snake.prototype.changeDirection = function (pressedKeyCode) {
                    this.direction = pressedKeyCode - 37;
                };

                Snake.prototype.size = function () {
                    return this.bodyLenght;
                };

                Snake.prototype.getSegment = function () {
                    return this.bodySegment;
                };

                Snake.prototype.generate = function (width, height) {
                    var i,
                        startX = parseInt(width / this.bodySegment / 2, 10) * this.bodySegment,
                        startY = parseInt(height / this.bodySegment / 2, 10) * this.bodySegment;
                    for (i = 0; i < this.bodyLenght; i++) {
                        this._body.push({ x: startX + i * this.bodySegment, y: startY });
                    }
                };

                Snake.prototype.move = function () {
                    this._forClear = {};
                    var j;
                    this._forClear.x = this._body[this.bodyLenght - 1].x;
                    this._forClear.y = this._body[this.bodyLenght - 1].y;
                    for (j = this.bodyLenght - 1; j >= 1; j--) {
                        this._body[j].x = this._body[j - 1].x;
                        this._body[j].y = this._body[j - 1].y;
                    }
                    switch (this.direction) {
                        case 0:
                            this._body[0].x -= this.bodySegment;
                            break;
                        case 1:
                            this._body[0].y -= this.bodySegment;
                            break;
                        case 2:
                            this._body[0].x += this.bodySegment;
                            break;
                        case 3:
                            this._body[0].y += this.bodySegment;
                            break;
                    }
                };

                return Snake;
            }());

        Food = (function () {
            function Food() {
                this._x = 0;
                this._y = 0;
                this.bodySegment = 20;
            }

            Food.prototype.generate = function (width, height) {
                this._x = parseInt(Math.random() * width / this.bodySegment, 10) * this.bodySegment;
                this._y = parseInt(Math.random() * height / this.bodySegment, 10) * this.bodySegment;
            };

            return Food;
        }());
        return {
            Snake: Snake,
            Food: Food
        };
    }());

    return objects;
});