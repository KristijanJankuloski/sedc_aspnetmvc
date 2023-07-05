function addPizza() {
    console.log("Add pizza");
    const selectElement = document.createElement("select");
    selectElement.className = "form-select";
    selectElement.name = "PizzaIds";
    const pizzaListDiv = document.getElementById("pizzaList");
    pizzaListDiv.appendChild(selectElement);
    let pizzaOptions = document.querySelector("#pizzaList select").querySelectorAll("option");

    for (let i = 0; i < pizzaOptions.length; i++) {
        selectElement.appendChild(pizzaOptions[i].cloneNode(true));
    }
}