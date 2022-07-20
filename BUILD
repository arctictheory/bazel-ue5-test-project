load("@rules_unreal//:rules/unreal_native_rules.bzl", "run_commandlet")
load("@rules_unreal//:rules/unreal_content_rules.bzl", "convert_data_validation_to_json")

alias(
    name = "unreal_project_file",
    actual = "@root_workspace//BazelTestProjectGame:BazelTestProjectGame.uproject",
)

alias(
    name = "unreal_executable",
    actual = "@unreal_engine//:Engine/Binaries/Win64/UnrealEditor-cmd.exe",
)


run_commandlet(
  name = "datavalidation",   
  engine_executable = "unreal_executable",
  project_file = "unreal_project_file",
  commandlet = "DataValidation"
  )

convert_data_validation_to_json(
  name="generate_asset_list",
  deps = ["@root_workspace//:datavalidation"]
  )