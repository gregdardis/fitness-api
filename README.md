# Fitness API

## Description
Fitness API is a RESTful web API that for accessing data about workout exercises. Exercises include the exercise name, it's main muscle group, the other muscle groups it works out, and the equipment required to perform the exercise. The API will return a JSON response containing an array of exercises meeting the specified criteria.

## Future Plans
In the future, exercises will have a URL for an instructional video on how to perform them, and stretches will be added to the database as well.
XML will also be supported, as well as more ways to customize your requests (requesting by main muscle group, contains muscle group, exact name, name contains a certain string, exercises that have a video that isn't null, exercises using certain equipment, etc).

## Install and Run
1. Clone or download this repository.
2. Open the project in Visual Studio 2017.

## Development Usage
Get all exercises without muscle groups or equipment:
`GET http://localhost:1029/api/exercises`

Get exercise by ID:
`GET http://localhost:1029/api/exercises/<id>`

Get all MuscleGroup choices
`GET http://localhost:1029/api/musclegroups`

Get all LiftingEquipment choices
`GET http://localhost:1029/api/liftingequipment/`

## Production Usage
The API is not hosted anywhere currently (coming soon).
