const mongoose = require('mongoose');

let filmSchema = mongoose.Schema({
    name: {type: 'string', require: 'true'},
    genre: {type: 'string', require: 'true'},
    director: {type: 'string', require: 'true'},
    year: {type: Number, require: 'true'}
});

let Film = mongoose.model('Film', filmSchema);

module.exports = Film;