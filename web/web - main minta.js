const baseUrl = 'http://localhost:3000';

// -- Objektumok
// Beviteli mezők
const inputId = document.querySelector('#id');
const inputNev = document.getElementById('nev');

// Gombok
const buttonReadAll = document.querySelector('#buttonReadall');
const buttonCreate = document.querySelector('#buttonCreate');
const buttonUpdate = document.querySelector('#buttonUpdate');
const buttonDelete = document.querySelector('#buttonDelete');
const buttonSelect = document.querySelector('#buttonSelect');

// -- Eseménykezelés
buttonCreate.addEventListener('click', insertElement);
buttonReadAll.addEventListener('click', readallElement);
buttonUpdate.addEventListener('click', updateElement);
buttonDelete.addEventListener('click', deleteElement);
buttonDelete.addEventListener('click', selectElement);

// -- Függvények
async function readallElement() { }
async function insertElement() { }
async function updateElement() { }
async function deleteElement() { }
//async function selectElement(inputId) { }
async function selectElement() {}
