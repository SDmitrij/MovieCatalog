function Catalog() {
}

Catalog.prototype = {
    modalPlaceholder: $("#modal-placeholder"),

    editMovie: function (id) {
        var that = this;      
        $.get("/Movie/Movie?handler=EditMovie", { movieId: id })
            .done(function (data) {
                that.modalPlaceholder.html(data);
                that.modalPlaceholder.find(".modal").modal("show");
            });

        this.modalPlaceholder.on("click", '[data-save="modal"]', function () {
            var form = $(this).parents(".modal").find("form");
            $.post(form.attr("action"), form.serialize())
                .done(function (data) {
                    var newBody = $(".modal-body", data);
                    that.modalPlaceholder.find(".modal-body").replaceWith(newBody);
                    var valid = newBody.find('[name="IsValid"]').val() == "True";
                    if (valid) {
                        that.modalPlaceholder.find(".modal").modal("hide");
                    }
                });
        });
    },

    deleteMovie: function (id) {
        var that = this;
        var url = "/Movie/Movie?handler=DeleteMovie"; 
        $.get(url)
            .done(function (data) {
                that.modalPlaceholder.html(data);
                that.modalPlaceholder.find(".modal").modal("show");
            });

        this.modalPlaceholder.on("click", '[data-delete="modal"]', function () {
            $.post(url, { movieId: id })
                .done(function () {
                    that.modalPlaceholder.find(".modal").modal("hide");
                    that.closest("tr").remove();
                });
        });
    },

    movieInfo: function (id) {
        var that = this;
        $.get("/Movie/Movie?handler=Info", { movieId: id })
            .done(function (data) {
                that.modalPlaceholder.html(data);
                that.modalPlaceholder.find(".modal").modal("show");
            });
    }
};

(function () {
    var catalog = new Catalog();
    $(document).on("click", "#editMovie", function () {
        catalog.editMovie($(this).data("movieId"));
    });
    $(document).on("click", "#deleteMovie", function () {
        catalog.deleteMovie($(this).data("movieId"));
    });
    $(document).on("click", "#movieInfo", function () {
        catalog.movieInfo($(this).data("movieId"));
    });
})();