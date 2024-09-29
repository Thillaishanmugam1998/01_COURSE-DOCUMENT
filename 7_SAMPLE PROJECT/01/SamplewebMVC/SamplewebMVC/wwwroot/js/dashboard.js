function showInsertForm() {
    hideAllSections();
    document.getElementById('insert-form').style.display = 'block';
}

function showUpdateForm() {
    hideAllSections();
    document.getElementById('update-form').style.display = 'block';
}

function showDeleteForm() {
    hideAllSections();
    document.getElementById('delete-form').style.display = 'block';
}

function showAllDetails() {
    hideAllSections();
    document.getElementById('details-table').style.display = 'block';

    // Logic to fetch all details (could be an AJAX request)
    fetchAllDetails();
}

function hideAllSections() {
    document.getElementById('insert-form').style.display = 'none';
    document.getElementById('update-form').style.display = 'none';
    document.getElementById('delete-form').style.display = 'none';
    document.getElementById('details-table').style.display = 'none';
}

function submitInsertForm() {
    // Logic to insert details (could be an AJAX request or form submission)
    alert("Inserting details...");
}

function submitUpdateForm() {
    // Logic to update details (could be an AJAX request or form submission)
    alert("Updating details...");
}

function submitDeleteForm() {
    // Logic to delete details (could be an AJAX request or form submission)
    alert("Deleting details...");
}

function fetchAllDetails() {
    // This function would fetch and display all details in the table.
    // You can make an AJAX call to get data, then populate the table.

    // Example of populating table with static data
    let tableBody = document.getElementById('details-body');
    tableBody.innerHTML = `
        <tr>
            <td>1</td>
            <td>John Doe</td>
            <td>1234567890</td>
            <td>john@example.com</td>
            <td>123 Main St</td>
        </tr>
        <tr>
            <td>2</td>
            <td>Jane Smith</td>
            <td>0987654321</td>
            <td>jane@example.com</td>
            <td>456 Oak Ave</td>
        </tr>
    `;
}
