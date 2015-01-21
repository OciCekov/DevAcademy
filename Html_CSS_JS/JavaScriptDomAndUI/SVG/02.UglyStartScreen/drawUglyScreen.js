/*globals document, window, alert*/

window.onload = function () {
    svgNs = 'http://www.w3.org/2000/svg';
    var theSvg = document.getElementById('theSvg');

    var background = createRect(10, 10, 800, 500, 'none');
    background.setAttribute('rx', 10);
    background.setAttribute('ry', 10);
    background.setAttribute('stroke', '#DAEDF2');
    background.setAttribute('stroke-width', 5);
    background.setAttribute('stroke-linejoin', 'round');
    theSvg.appendChild(background);

    var backgroundImg = createImage(12, 4, 797, 510, 'http://fc04.deviantart.net/fs70/i/2012/218/3/4/windows_8_pro_start_wallpaper_2_by_brebenel_silviu-d5a2o6h.jpg');
    theSvg.appendChild(backgroundImg);

// Store
    var squareTile = createRect(50, 100, 60, 60, '#2978F0');
    theSvg.appendChild(squareTile);
    var tileImage = createImage(60, 110, 40, 40, 'imgs/store.jpg');
    theSvg.appendChild(tileImage);
    var tileText = writeText(55, 155, 'Store', 9, 'white', 'normal', 'Miramonte');
    theSvg.appendChild(tileText);

// Xbox
    squareTile = createRect(115, 100, 60, 60, '#5FAB17');
    theSvg.appendChild(squareTile);
    tileImage = createImage(125, 110, 40, 40, 'imgs/xbox.jpg');
    theSvg.appendChild(tileImage);
    tileText = writeText(120, 155, 'Xbox Live', 9, 'white', 'normal', 'Miramonte');
    theSvg.appendChild(tileText);

// the most useless thing ever!
    squareTile = createRect(115, 165, 60, 60, '#2978F0');
    theSvg.appendChild(squareTile);
    tileImage = createImage(125, 170, 40, 40, 'imgs/theHorror.jpg');
    theSvg.appendChild(tileImage);
    tileText = writeText(120, 220, 'Useless', 9, 'white', 'normal', 'Miramonte');
    theSvg.appendChild(tileText);

// Maps
    squareTile = createRect(50, 165, 60, 60, '#613DBB');
    theSvg.appendChild(squareTile);
    tileImage = createImage(60, 170, 40, 40, 'imgs/maps.jpg');
    theSvg.appendChild(tileImage);
    tileText = writeText(55, 220, 'Maps', 9, 'white', 'normal', 'Miramonte');
    theSvg.appendChild(tileText);

// Video
    var rectangleTile = createRect(50, 230, 125, 60, '#D44E2B');
    theSvg.appendChild(rectangleTile);
    tileImage = createImage(90, 235, 45, 45, 'imgs/video.jpg');
    theSvg.appendChild(tileImage);
    tileText = writeText(55, 285, 'Video', 9, 'white', 'normal', 'Miramonte');
    theSvg.appendChild(tileText);

// Fish
    tileImage = createImage(50, 260, 125, 130, 'imgs/fishy.jpg');
    theSvg.appendChild(tileImage);

// Profiles
    rectangleTile = createRect(180, 100, 125, 60, '#B11B41');
    theSvg.appendChild(rectangleTile);
    tileImage = createImage(218, 105, 45, 45, 'imgs/profiles.jpg');
    theSvg.appendChild(tileImage);
    tileText = writeText(190, 155, 'Profiles', 9, 'white', 'normal', 'Miramonte');
    theSvg.appendChild(tileText);

// Messages
    rectangleTile = createRect(180, 165, 125, 60, '#5535B0');
    theSvg.appendChild(rectangleTile);
    tileImage = createImage(218, 170, 45, 45, 'imgs/messages.jpg');
    theSvg.appendChild(tileImage);
    tileText = writeText(190, 219, 'Messaging', 9, 'white', 'normal', 'Miramonte');
    theSvg.appendChild(tileText);

// Mails
    rectangleTile = createRect(180, 230, 125, 60, '#009018');
    theSvg.appendChild(rectangleTile);
    var tileHeading = writeText(190, 250, 'Devon Hypnotize', 15, 'white');
    theSvg.appendChild(tileHeading);
    tileText = writeText(190, 265, 'Here is some mail ', 9, 'white', 'normal', 'Miramonte');
    theSvg.appendChild(tileText);

// Weather
    rectangleTile = createRect(180, 295, 125, 60, '#2978F0');
    theSvg.appendChild(rectangleTile);
    tileImage = createImage(218, 300, 45, 45, 'imgs/weather.jpg');
    theSvg.appendChild(tileImage);
    tileText = writeText(190, 350, 'Weather', 9, 'white', 'normal', 'Miramonte');
    theSvg.appendChild(tileText);

// Calendar
    rectangleTile = createRect(310, 100, 125, 60, '#009018');
    theSvg.appendChild(rectangleTile);
    tileText = writeText(320, 155, 'Calendar', 9, 'white', 'normal', 'Miramonte');
    theSvg.appendChild(tileText);
    tileHeading = writeText(390, 130, '12', 33, 'white');
    theSvg.appendChild(tileHeading);
    tileText = writeText(394, 140, 'Monday', 10, 'white', 'normal', 'Consolas');
    theSvg.appendChild(tileText);

// Contacts
    tileImage = createImage(310, 130, 125, 130, 'imgs/contacts.jpg');
    theSvg.appendChild(tileImage);

// Planet
    tileImage = createImage(306, 230, 65, 55, 'imgs/planet.jpg');
    theSvg.appendChild(tileImage);

// Camera
    squareTile = createRect(310, 295, 60, 60, '#B11B41');
    theSvg.appendChild(squareTile);
    tileImage = createImage(320, 300, 40, 40, 'imgs/camera.jpg');
    theSvg.appendChild(tileImage);
    tileText = writeText(320, 350, 'Camera', 9, 'white', 'normal', 'Miramonte');
    theSvg.appendChild(tileText);

// Solitare
    squareTile = createRect(375, 230, 60, 60, '#2978F0');
    theSvg.appendChild(squareTile);
    tileImage = createImage(385, 235, 40, 40, 'imgs/solitare.jpg');
    theSvg.appendChild(tileImage);
    tileText = writeText(380, 285, 'Solitare', 9, 'white', 'normal', 'Miramonte');
    theSvg.appendChild(tileText);

// Xbox companion
    squareTile = createRect(375, 295, 60, 60, '#5FAB17');
    theSvg.appendChild(squareTile);
    tileImage = createImage(385, 299, 40, 40, 'imgs/xboxCompanion.jpg');
    theSvg.appendChild(tileImage);
    tileText = writeText(380, 350, 'xbox comp', 9, 'white', 'normal', 'Miramonte');
    theSvg.appendChild(tileText);

// Music
    rectangleTile = createRect(440, 100, 125, 60, '#5535B0');
    theSvg.appendChild(rectangleTile);
    tileImage = createImage(480, 105, 45, 45, 'imgs/phones.jpg');
    theSvg.appendChild(tileImage);
    tileText = writeText(450, 155, 'Mussic', 9, 'white', 'normal', 'Miramonte');
    theSvg.appendChild(tileText);

// Money
    rectangleTile = createRect(440, 165, 125, 60, '#009018');
    theSvg.appendChild(rectangleTile);
    tileImage = createImage(480, 165, 45, 45, 'imgs/finance.jpg');
    theSvg.appendChild(tileImage);
    tileText = writeText(450, 219, 'Finances', 9, 'white', 'normal', 'Miramonte');
    theSvg.appendChild(tileText);

// pdf reader
    squareTile = createRect(440, 230, 60, 60, '#D44E2B');
    theSvg.appendChild(squareTile);
    tileImage = createImage(450, 240, 40, 40, 'imgs/pdfReader.jpg');
    theSvg.appendChild(tileImage);
    tileText = writeText(445, 285, 'Reader', 9, 'white', 'normal', 'Miramonte');
    theSvg.appendChild(tileText);

// windows explorer
    squareTile = createRect(505, 230, 60, 60, '#002866');
    theSvg.appendChild(squareTile);
    tileImage = createImage(510, 265, 20, 20, 'imgs/windowsExplorer.jpg');
    theSvg.appendChild(tileImage);
    tileText = writeText(510, 245, 'Windows', 10, 'white');
    theSvg.appendChild(tileText);
    tileText = writeText(510, 255, 'Explorer', 10, 'white');
    theSvg.appendChild(tileText);

// News
    tileImage = createImage(440, 260, 125, 130, 'imgs/news.jpg');
    theSvg.appendChild(tileImage);

// S thing
    squareTile = createRect(570, 100, 60, 60, '#E7E5DD');
    theSvg.appendChild(squareTile);
    tileImage = createImage(567, 110, 50, 50, 'imgs/sThing.jpg');
    theSvg.appendChild(tileImage);

// Penguin, I really have no idea what is this
    squareTile = createRect(570, 165, 60, 60, '#0072B4');
    theSvg.appendChild(squareTile);
    tileImage = createImage(585, 175, 40, 40, 'imgs/penguin.jpg');
    theSvg.appendChild(tileImage);
    tileText = writeText(575, 220, 'Solitare', 9, 'white', 'normal', 'Miramonte');
    theSvg.appendChild(tileText);

// SkyDrive
    squareTile = createRect(570, 230, 60, 60, '#2978F0');
    theSvg.appendChild(squareTile);
    tileImage = createImage(585, 235, 40, 40, 'imgs/skyDrive.jpg');
    theSvg.appendChild(tileImage);
    tileText = writeText(580, 285, 'SkyDrive', 9, 'white', 'normal', 'Miramonte');
    theSvg.appendChild(tileText);

// Start
    var start = writeText(50, 60, 'Start', 30, 'white', 'normal', 'Miramonte');
    theSvg.appendChild(start);

// User profile  and yes there was no way to go without Pesho.
    var ownerFirstName = writeText(520, 60, 'Pesho', 17, 'white', 'normal', 'Miramonte');
    theSvg.appendChild(ownerFirstName);
    var ownerFamilyName = writeText(540, 68, 'Perry', 11, 'white', 'normal', 'Miramonte');
    theSvg.appendChild(ownerFamilyName);
    var ownerImage = createImage(565, 45, 35, 35, 'imgs/Pesho.jpg');
    theSvg.appendChild(ownerImage);
};