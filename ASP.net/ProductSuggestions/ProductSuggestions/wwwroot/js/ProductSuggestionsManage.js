// Send an Ajax request to GET a product suggestion.
function getProductSuggestion() {

    // If the user didn't enter an id, return immediately.
    var id = $("#id").val();
    if (id === "")
        return;

    // Clear all the text boxes.
    clearProductSuggestion();

    // Send an Ajax request to GET a product suggestion with the specified id.
    var theUrl = "/api/productsuggestions/" + id;
    $.ajax({
        type: "GET",
        url: theUrl,
        cache: false,

        accepts: {
            json: 'application/json'
        },

        success: function (data, status, xhr) {
            displayProductSuggestion(data);
        },

        error: function (xhr, message, errorThrown) {
            displayError(xhr, message, errorThrown);
        }
    });
}


// Send an Ajax request to POST (insert) a product suggestion.
function insertProductSuggestion() {

    // Create a ProductSuggestion object, and set its properties based on user input. 
    var productSuggestion = {
        description: $("#description").val(),
        minPrice: Number($("#minPrice").val()),
        maxPrice: Number($("#maxPrice").val()),
        estimatedSales: Number($("#estimatedSales").val())
    };

    // Send an Ajax request to POST the object to the service. 
    var theUrl = "/api/productsuggestions";
    $.ajax({
        type: "POST",
        url: theUrl,
        cache: false,
        contentType: "application/json",
        data: JSON.stringify(productSuggestion),

        success: function (data, status, xhr) {
            displayProductSuggestion(data);
            alert("Inserted item successfully, location is " + xhr.getResponseHeader("Location"));
        },

        error: function (xhr, message, errorThrown) {
            displayError(xhr, message, errorThrown);
        }
    });
}


// Send an Ajax request to PUT (update) a product suggestions.
function updateProductSuggestion() {

    // If the user didn't enter an id, return immediately.
    var id = $("#id").val();
    if (id === "")
        return;

    // Create a ProductSuggestion object, and set its properties based on user input. 
    var productSuggestion = {
        id: Number(id),
        description: $("#description").val(),
        minPrice: Number($("#minPrice").val()),
        maxPrice: Number($("#maxPrice").val()),
        estimatedSales: Number($("#estimatedSales").val())
    };

    // Send an Ajax request to PUT the object to the service. 
    var theUrl = "/api/productsuggestions/" + id;
    $.ajax({
        type: "PUT",
        url: theUrl,
        cache: false,
        contentType: "application/json",
        data: JSON.stringify(productSuggestion),

        success: function (data, status, xhr) {
            alert("Updated item successfully");
        },

        error: function (xhr, message, errorThrown) {
            displayError(xhr, message, errorThrown);
        }
    });
}


// Send an Ajax request to DELETE a product suggestion.
function deleteProductSuggestion() {

    // If the user didn't enter an id, return immediately.
    var id = $("#id").val();
    if (id === "")
        return;

    // Clear all the text boxes.
    clearProductSuggestion();

    // Send an Ajax request to DELETE the product suggestion with the specified id.
    var theUrl = "/api/productsuggestions/" + id;
    $.ajax({
        type: "DELETE",
        url: theUrl,
        cache: false,

        success: function (data, status, xhr) {
            alert("Deleted item successfully");
        },

        error: function (xhr, message) {
            displayError(xhr, message, $("#id").val());
        }
    });
}


// Helper function, to clear the text boxes.
function clearProductSuggestion() {
    $("#id").val("");
    $("#description").val("");
    $("#minPrice").val("");
    $("#maxPrice").val("");
    $("#estimatedSales").val("");
}


// Helper function, to display a product suggestion object in the text boxes.
function displayProductSuggestion(productSuggestion) {
    $("#id").val(productSuggestion.id);
    $("#description").val(productSuggestion.description);
    $("#minPrice").val(productSuggestion.minPrice);
    $("#maxPrice").val(productSuggestion.maxPrice);
    $("#estimatedSales").val(productSuggestion.estimatedSales);
}


// Helper function, to display an error message.
function displayError(xhr, message, errorThrown) {
    if (xhr.status === 404) {
        alert("Item not found");
    }
    else {
        alert("Ajax error occurred: " + errorThrown);
    }
}