﻿// Copyright 2020 Andreas Atteneder
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

namespace GLTFast
{
    public class GltfAsset : GltfAssetBase
    {
        public string url;
        public bool loadOnStartup = true;
        public bool uploadMeshOnLoad = true;

        protected virtual void Start() {
            if(loadOnStartup && !string.IsNullOrEmpty(url)) {
                // Automatic load on startup
                Load(url, uploadMeshOnLoad);
            }
        }

        protected override void OnLoadComplete(bool success) {
            if(success) {
                // Auto-Instantiate
                gLTFastInstance.InstantiateGltf(transform);
            }
            base.OnLoadComplete(success);
        }
    }
}
