const express = require('express');
const cors = require('cors');
const mysql = require('mysql');
const path = require('path');
const bodyParser = require('body-parser');

const app = express();
const port = 3000;

app.use(cors());
app.use(express.json());
app.use(express.urlencoded({extended: false}));
app.use(express.static(path.join(__dirname, '..', 'frontend')));

// MySql kapcsolat
const connection = mysql.createConnection({
    host: 'localhost',
    user: 'root',
    password: '',
    database: 'adatbazisneve',
});
connection.connect;

app.get('/', function (req, res) {
    res.sendFile(path.join(__dirname, '..', 'frontend/index.html'));
});


app.listen(port, function () {
    console.log(`Portszám: ${port}`);
});
