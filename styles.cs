body {
    font-family: Arial, sans-serif;
    background-color: #f0f0f0;
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    margin: 0;
}

.container {
    background-color: white;
    padding: 20px;
    border-radius: 10px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
}

h1 {
    color: #133a75;
    text-align: center;
}

table {
    width: 100%;
    border-collapse: collapse;
}

th, td {
    padding: 10px;
    border: 1px solid #ddd;
    text-align: center;
}

th {
    background-color: #1c5d9c;
    color: white;
}

td[contenteditable="true"] {
    background-color: #da2c5a;
    color: white;
    cursor: pointer;
}

td[contenteditable="true"]:hover {
    background-color: #02a7d1;
}

button {
    background-color: #133a75;
    color: white;
    padding: 10px 20px;
    border: none;
    border-radius: 5px;
    cursor: pointer;
    display: block;
    margin: 20px auto 0;
}

button:hover {
    background-color: #1c5d9c;
}
