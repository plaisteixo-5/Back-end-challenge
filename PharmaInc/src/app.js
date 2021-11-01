const express = require('express');
const mongoose = require('mongoose');
const config = require('./config');
require('dotenv').config();

const app = express();

const {
    DB_USER,
    DB_PASS,
    DB_HOST,
    DB_PORT,
    DB_NAME
} = process.env

mongoose.connect(
    `mongodb://${DB_USER}:${DB_PASS}@${DB_HOST}:${DB_PORT}/${DB_NAME}?authSource=admin`, {
        useNewUrlParser: true,
    }
)

const User = require('./models/user');

const indexRoute = require('./routes/index-route');
const userRoute = require('./routes/user-route');

app.use(express.json());
app.use(express.urlencoded({
    extended: false
}));

app.use('/', indexRoute);
app.use('/users', userRoute);

module.exports = app;