export function throwIfAlreadyLoaded(parentModule: any, moduleName: string): void {
  if (parentModule) {
    throw new Error(
      `${moduleName} has already been loaded. Import ${moduleName} only once (e.g., in the root application configuration).`
    );
  }
}
