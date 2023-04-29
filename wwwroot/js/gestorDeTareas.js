$(document).ready(function () {
    cargarTareas();

    function cargarTareas() {
        $.ajax({
            url: "/Tareas/ObtenerTareas",
            type: "GET",
            dataType: "json",
            success: function (tareas) {
                var tbody = $("#tabla-tareas tbody");
                tbody.empty();

                tareas.forEach(function (tarea) {
                tareas.forEach(function (tarea) {
                    var fila = $("<tr></tr>");
                    fila.append($("<td></td>").text(tarea.Nombre));
                    fila.append($("<td></td>").text(tarea.Descripcion));
                    fila.append($("<td></td>").text(tarea.Completada ? "Sí" : "No"));

                    tbody.append(fila);
                });
            },
            error: function () {
                alert("Error al cargar las tareas. Por favor, inténtalo de nuevo.");
            }
        });
    }
});
