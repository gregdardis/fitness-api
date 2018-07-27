# Fitness API

## Description
Fitness API is a RESTful web API for accessing data about workout exercises. Exercises include the exercise name, it's main muscle group, the other muscle groups it works out, and the equipment required to perform the exercise. The API will return a JSON response containing an array of exercises meeting the specified criteria.

## Future Plans
In the future, exercises will have a URL for an instructional video on how to perform them. Stretches will also be added to the database in addition to Exercises.
XML will also be supported, as well as more ways to customize your requests (requesting by main muscle group, contains muscle group, exact name, name contains a certain string, exercises that have a video that isn't null, exercises using certain equipment, etc).

## Install and Run
1. Clone or download this repository.
2. Open the project in Visual Studio 2017.

## Development Usage

### Exercise Getters
Get all Exercises without muscle groups or lifting equipment:
`GET http://localhost:1029/api/exercises`

Get Exercise by id:
`GET http://localhost:1029/api/exercises/<id>`

Get Exercises with main muscle group
`GET http://localhost:1029/api/exercises/main-muscle-group/<muscleGroup>`

Get Exercise containing muscle group
`GET http://localhost:1029/api/exercises/contains-muscle-group/<muscleGroup>`

Get Exercise by name
`GET http://localhost:1029/api/exercises/<exerciseName>`

Get Exercises using lifting equipment
`GET http://localhost:1029/api/exercises/uses-equipment/<equipment>`

### MuscleGroup Getters
Get all muscle group choices
`GET http://localhost:1029/api/musclegroups`

#### Muscle Group Choices:
- Abs
- Back
- Biceps
- Calves
- Chest
- Core
- Forearms
- Glutes
- Hamstrings
- LowerBack
- Obliques
- Quads
- RearDelts
- Shoulders
- Traps
- Triceps
**Note: May not be up to date. Use the above endpoint to see all muscle group choices.**

### LiftingEquipment Getters
Get all lifting equipment choices
`GET http://localhost:1029/api/liftingequipment/`

#### Lifting Equipment Choices:
- AbWheel
- Barbell
- Bodyweight
- Cable
- ChinUpBar
- DeclineBench
- DipBar
- Dumbbell
- EZBar
- FlatBench
- HammerGripPullupBar
- InclineBench
- Kettlebell
- Machine
- MedicineBall
- PowerRack
- PullupBar
- ResistanceBand
- SeatedBench
- SmithMachine
- SquatBox
- SquatRack
- TrapBar
- WorkoutPartner
**Note: May not be up to date. Use the above endpoint to see all lifting equipment choices.**

## Production Usage
The API is not hosted anywhere currently (coming soon).
