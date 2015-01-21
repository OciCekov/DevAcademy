define(["underscore", "collections"], function (_, collections) {
    var animals,
        collectionToReturn = 0;
    animals = collections.animals;

    _.each(animals, function (animal) {
        collectionToReturn += animal.legsCount;
    })
    return collectionToReturn;
});
