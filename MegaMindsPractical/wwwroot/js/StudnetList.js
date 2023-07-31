function fetchAndInitializeDataTable() {
    //var token = localStorage.getItem("token");
    debugger
    jQuery.ajax({
        url: 'VisaMaster/GetAllData', // Replace with your server-side endpoint URL
        type: 'GET',
        success: function (data) {
            debugger
            // Initialize DataTable with the fetched data
            new DataTable('#example', {
                destroy: true, // Destroy the existing DataTable if any
                data: data,
                columns: [
                    { title: 'Visa Holder Name', data: 'visaHolderName' },
                    { title: 'Visa Type', data: 'visaType' },
                    { title: 'Age', data: 'age' },
                    {
                        title: 'Status',
                        data: 'status',
                        render: function (data, type, row) {
                            if (data === true) {
                                return '<a href="#" class="status-image-green"><img src="/Image/right.png" class="green-image" ></a>';
                            } else {
                                return '<a href="#" class="status-image-red"><img src="/Image/cross.jpg" class="red-image"></a>';
                            }
                        }
                    },
                ]
            });
        },
        error: function (error) {
            console.error('Error fetching data:', error);
        }
    });
}

$(document).ready(function () {
    fetchAndInitializeDataTable();
    // Call the function at regular intervals (e.g., every 10 seconds)
    //setTimeout(fetchAndInitializeDataTable, 10000); // 10000 milliseconds (10 seconds)
});