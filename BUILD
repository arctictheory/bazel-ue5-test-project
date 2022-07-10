load("@rules_unreal//:unreal_rules.bzl", "compile_blueprint", "run_commandlet")
load("@rules_unreal//:tools.bzl", "convert_data_validation_to_json")

alias(
    name = "unreal_project_file",
    actual = "@root_workspace//BazelTestProjectGame:BazelTestProjectGame.uproject",
)

compile_blueprint(
  name = "compile_bp",
  engine_executable = "@unreal_engine//:Engine/Binaries/Win64/UnrealEditor-cmd.exe",
  project_file = "unreal_project_file",
  blueprint = "@root_workspace//BazelTestProjectGame:Content/ThirdPerson/Blueprints/BP_ThirdPersonCharacter.uasset"
  )

run_commandlet(
  name = "datavalidation",   
  engine_executable = "@unreal_engine//:Engine/Binaries/Win64/UnrealEditor-cmd.exe",
  project_file = "unreal_project_file",
  commandlet = "DataValidation"
  )

convert_data_validation_to_json(
  name="generate_asset_list",
  deps = ["@root_workspace//:datavalidation"]
  )