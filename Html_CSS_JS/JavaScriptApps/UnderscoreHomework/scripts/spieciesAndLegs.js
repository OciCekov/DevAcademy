define(["underscore", "collections"], function (_, collections) {
    var animals,
        collectionToReturn,
        result;
    collectionToReturn = String();
    animals = collections.animals;
    result = _.sortBy(animals, "legs");
    _.groupBy(result, "species");
    _.each(result, function (animal) {
        collectionToReturn += JSON.stringify(animal) + "<br>";
    });
    return collectionToReturn;
});
