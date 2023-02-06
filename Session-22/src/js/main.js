/*
1. Write a Javascript function that will accept a string as parameter and return it reversed 
(ex. Input “Mark”, output: “kraM” ). Create a simple UI that will accept the input and then 
present the result.
*/

function reverseString() {

    const str = 'Ioannis Koukotzilas';

    const revStr = (str) => {
        return str.split('').reverse().join('');
    };

    console.log(revStr(str));

}

reverseString();


/*
2. Create a javascript function that will check if a string is a palindrome (reads the same 
    backward as forward).
*/

function palindromeString() {

    const str = 'Sofos';
    const lowerStr = str.toLowerCase();

    const revStr = (lowerStr) => {
        return lowerStr.split('').reverse().join('');
    };

    if (lowerStr === revStr(lowerStr)) {
        console.log(`${lowerStr} is a palindrome`);
    } else {
        console.log(`${lowerStr} is not a palindrome`);
    }

}

palindromeString();


/*
3. Create a page that will contain a Customer Detail form which will contain input controls 
for the Customer details (Name, Surname, Age, Gender). All the stored Customers will be presented 
in a table. If a table row is clicked, the customer details should be rendered below the table in
 an appropriate area using labels and inputs.
*/

function insertCustomer() {

    const customers = [];

    const customerInput = document.getElementById('customer-input');

    const name = customerInput.querySelector('#name').value;
    const surname = customerInput.querySelector('#surname').value;
    const age = customerInput.querySelector('#age').value;
    const gender = customerInput.querySelector('input[name="gender"]:checked').value;

    const table = document.getElementById("tblCustomers");

    const newCustomer = {
        id: customers.length + 1,
        name: name,
        surname: surname,
        age: age,
        gender: gender,
    };

    customers.push(newCustomer);

    createTableRow(newCustomer, table);
}

function createTableRow(customer, tableEl) {
    let rowEl = tableEl.insertRow();

    rowEl.setAttribute('data-id', customer.id);

    rowEl.addEventListener('click', (event) => {
        selectRow(event.currentTarget);
    });

    let idEl = rowEl.insertCell(0);
    idEl.innerHTML = customer.id;

    let nameEl = rowEl.insertCell(1);
    nameEl.innerHTML = customer.name;

    let surnameEl = rowEl.insertCell(2);
    surnameEl.innerHTML = customer.surname;

    let ageEl = rowEl.insertCell(3);
    ageEl.innerHTML = customer.age;

    let genderEl = rowEl.insertCell(4);
    genderEl.innerHTML = customer.gender;
}


/*
4. Complete (if needed) the following function.
*/

function multiply(a, b) {
    return a * b;
}

// I think it's OK

console.log(multiply(5, 20));

/*
5. Write a function that accepts string as an input and returns a new string that:
a. If the string ends with a number, the number should be incremented by 1 (ex. Foo22->Foo23)
b. If the string does not end with a number, the number 1 should be added at the end (ex. Foo->Foo1)
*/

function incrementString() {

    const str = 'Foo22';

    const lastChar = str.charAt(str.length - 1);

    console.log(lastChar);

    const isNumber = !isNaN(lastChar);

    console.log(isNumber);

    if (isNumber) {
        const newNum = parseInt(lastChar) + 1;
        console.log(str.slice(0, -1) + newNum);
    } else {
        console.log(str + 1);
    }

}

incrementString();








