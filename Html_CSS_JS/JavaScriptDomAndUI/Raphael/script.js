var container = Raphael('svg-container', 300, 300);

// Telerik logo
container.rect(10, 10, 250, 80)
    .attr({
        stroke: 'green',
        ' stroke-width': 1,
        fill: 'white'
    });

container.text(150, 45, 'Telerik')
    .attr({
        'font-size': 35,
        'font-weight': 'bold'
    });

container.text(172, 67, 'Develop experiences')
    .attr({
        fill: 'gray',
        'font-size': 15
    });

container.image('imgs/telerikLogo.png', 20, 20, 50, 50);

// YouTube
container.rect(10, 150, 250, 80)
    .attr({
        stroke: 'pink',
        'stroke-width': 1,
        fill: 'white'
    });

container.text(70, 190, 'You')
    .attr({
        'font-size': 55,
        'font-weight': 'bold',
        fill: 'gray'
    });
container.rect(130, 160, 120, 60, 20)
    .attr({
        fill: 'red'
    });
container.text(190, 190, 'tube')
    .attr({
        'font-size': 55,
        fill: 'white',
        'font-weight': 'bold'
    });