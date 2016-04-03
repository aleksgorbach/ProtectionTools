/// <binding BeforeBuild='css:uglify, js:concat' />
var gulp = require('gulp'),
    concat = require('gulp-concat'),
    uglify = require("gulp-cssmin"),
    rename = require("gulp-rename"),
    concatCss = require("gulp-concat-css");
    

gulp.task("js:concat", function() {
    return gulp.src([
        "lib/jquery/dist/jquery.js",
        "lib/bootstrap/dist/js/bootstrap.js",
        "lib/angular/angular.js",
        "Scripts/*.js",
    ])
        .pipe(concat("app.js"))
        .pipe(gulp.dest("wwwroot/js/"));
});

gulp.task("css:uglify", function() {
    return gulp.src([
            "lib/bootstrap/dist/css/bootstrap.css",
            "lib/bootswatch/paper/bootstrap.css",
            "Styles/site.css"
    ])
        .pipe(concatCss("styles.css"))
        //.pipe(uglify())
        //.pipe(rename({suffix: ".min"}))
        .pipe(gulp.dest("wwwroot/css/"));
});
