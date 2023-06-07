//-- readall
app.get('/readall', function (req, res) { });
//connection.query(sql, (err, rows) => {});

//-- create
app.post('/create', function (req, res) { });
//connection.query(sql, data, (err) => {});
//INSERT INTO table SET ?

//-- read
app.get('/read/:id', function (req, res) { });
//connection.query(sql, (err, row) => {});

//-- update
app.put('/update/:id', function (req, res) { });
//connection.query(sql, (err) => {});
// UPDATE table SET valami='${value}'

//-- delete
app.delete('/delete/:id', function (req, res) { });
//connection.query(sql, (err) => {});