load("@rules_unreal//:rules/unreal_native_rules.bzl", "compile_blueprint")
package(default_visibility = ["//visibility:public"])

exports_files(glob(["**"]))

alias(
    name = "unreal_project_file",
    actual = "@root_workspace//BazelTestProjectGame:BazelTestProjectGame.uproject",
)

alias(
    name = "unreal_executable",
    actual = "@unreal_engine//:Engine/Binaries/Win64/UnrealEditor-cmd.exe",
)

#### Generated actions! Do not modify bellow! ####
compile_blueprint(
    name = "bp_thirdpersongamemode",
    engine_executable = "unreal_executable",
    project_file = "unreal_project_file",
    blueprint = "//BazelTestProjectGame/Content:thirdperson/blueprints/bp_thirdpersongamemode.uasset")
    
compile_blueprint(
    name = "bp_thirdpersoncharacter",
    engine_executable = "unreal_executable",
    project_file = "unreal_project_file",
    blueprint = "//BazelTestProjectGame/Content:thirdperson/blueprints/bp_thirdpersoncharacter.uasset")