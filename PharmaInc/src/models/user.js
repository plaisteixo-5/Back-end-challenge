const mongoose = require('mongoose');
const Schema = mongoose.Schema;

const schema = new Schema({
    gender: String,
    name: {
        title: String,
        first: String,
        last: String,
    },
    location: {
        street: {
            number: Number,
            name: String
        },
        city: String,
        state: String,
        postcode: Number,
        cordinates: {
            latitude: Number,
            longitude: Number
        },
        timezone: {
            offset: String,
            description: String
        }
    },
    email: String,
    login: {
        uuid: String,
        username: String,
        password: String,
        salt: String,
        md5: String,
        sha1: String,
        sha256: String
    },
    dob: {
        date: Date,
        age: Number
    },
    registered: {
        date: Date,
        age: Number
    },
    phone: String,
    cell: String,
    Publicid: {
        name: String,
        value: String
    },
    picture: {
        large: String,
        medium: String,
        thumbnail: String
    },
    nat: String
});

module.exports = mongoose.model('User', schema);