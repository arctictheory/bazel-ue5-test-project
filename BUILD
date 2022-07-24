load("@rules_unreal//:rules/unreal_native_rules.bzl", "run_commandlet")
load("@rules_unreal//:rules/unreal_content_rules.bzl", "get_project_overview", "inject_blueprints_to_build_file")

alias(
    name = "unreal_project_file",
    actual = "@root_workspace//BazelTestProjectGame:BazelTestProjectGame.uproject",
)

alias(
    name = "unreal_executable",
    actual = "@unreal_engine//:Engine/Binaries/Win64/UnrealEditor-cmd.exe",
)

run_commandlet(
  name = "unreal_commandlet_DataValidation",   
  engine_executable = "unreal_executable",
  project_file = "unreal_project_file",
  commandlet = "DataValidation"
  )

get_project_overview(
  name="project_overview",
  deps = ["@root_workspace//:unreal_commandlet_DataValidation"]
  )

inject_blueprints_to_build_file (
  name="generate_content_buildfile",
  project_overview_file = "@root_workspace//:project_overview",
  project_folder_name = "BazelTestProjectGame"

)
