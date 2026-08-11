$(document).ready(function () {
    loadDataTable();
});

function loadDataTable
{
    dataTable = new DataTable('#tblData', {
        "ajax": '/admin/product/getall'
    },
        "columns": [
        { data: 0 },
        { data: 1 },
        { data: 2 },
        { data: 3 },
        { data: 4 },
        { data: 5 }
    ]
   );
}

