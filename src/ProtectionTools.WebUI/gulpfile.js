/// <binding BeforeBuild='css' />
var gulp = require('gulp'),
    concat = require('gulp-concat'),
    uglify = require("gulp-cssmin"),
    rename = require("gulp-rename"),
    concatCss = require("gulp-concat-css"),
    sass = require("gulp-sass");
    

gulp.task("js:concat", function() {
    return gulp.src([
        "lib/jquery/dist/jquery.js",
        "lib/bootstrap/dist/js/bootstrap.js",
        "lib/angular/angular.js",
        "lib/angular-route/angular-route.js",
        "lib/angular-messages/angular-messages.js",
        "Scripts/app.js",
        "Scripts/services/electricityService.js",
        "Scripts/controllers/appController.js"
    ])
        //.pipe(concat("app.js"))
        .pipe(gulp.dest("wwwroot/js/"));
});

gulp.task("css:compile", function() {
    return gulp.src([
            "Styles/site.scss"
    ])
        .pipe(sass())
        .pipe(gulp.dest("Styles/dist/"));
})

gulp.task("css:concat", function() {
    return gulp.src([
            "lib/bootstrap/dist/css/bootstrap.css",
            "lib/bootswatch/paper/bootstrap.css",
            "Styles/dist/site.css"
    ])
        .pipe(concatCss("styles.css"))
        //.pipe(uglify())
        //.pipe(rename({suffix: ".min"}))
        .pipe(gulp.dest("wwwroot/css/"));
});

gulp.task("css", function() {
    gulp.run("css:compile", "css:concat");
})
