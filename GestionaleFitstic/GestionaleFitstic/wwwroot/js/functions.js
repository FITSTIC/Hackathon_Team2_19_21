function search() {
    var input, filter, table, tr, td, i, txtValue;
    input = document.getElementById("searchInput");
    filter = input.value.toUpperCase();
    table = document.getElementById("dataTable");
    tr = table.getElementsByTagName("tr");
    thead = table.getElementsByTagName("thead")     
    for (i = 0; i < tr.length; i++) {
        for (c = 0; c < tr.length; c++) {
            td = tr[i].getElementsByTagName("td")[c];
            if (td) {
                txtValue = td.textContent || td.innerText;
                if (txtValue.toUpperCase().indexOf(filter) > -1) {
                    tr[i].style.display = "";
                    break;
                }
                else {
                    tr[i].style.display = "none";
                }
            }
        }
    }
}
