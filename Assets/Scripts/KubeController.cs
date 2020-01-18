using System;
//using k8s;
//using System.Net;
//using System.Net.Http;
using UnityEngine;

public class KubeController : MonoBehaviour {

    //static HttpClient client = new HttpClient();

    // TODO find a way to load/import these
    //private static String url = "https://172.31.1.56:16443";
    //private static String token = "eyJhbGciOiJSUzI1NiIsImtpZCI6IlJPYmVxSXd6MFR1Q1FibDc2WnhUWUpHbEstbG9nS0hFXzYxaTBJRjlHQXMifQ.eyJpc3MiOiJrdWJlcm5ldGVzL3NlcnZpY2VhY2NvdW50Iiwia3ViZXJuZXRlcy5pby9zZXJ2aWNlYWNjb3VudC9uYW1lc3BhY2UiOiJkZWZhdWx0Iiwia3ViZXJuZXRlcy5pby9zZXJ2aWNlYWNjb3VudC9zZWNyZXQubmFtZSI6ImRlZmF1bHQtdG9rZW4tYmJmcGgiLCJrdWJlcm5ldGVzLmlvL3NlcnZpY2VhY2NvdW50L3NlcnZpY2UtYWNjb3VudC5uYW1lIjoiZGVmYXVsdCIsImt1YmVybmV0ZXMuaW8vc2VydmljZWFjY291bnQvc2VydmljZS1hY2NvdW50LnVpZCI6ImU0MjY3YmNiLTliMTgtNDhlNC04M2Y4LTI5MTAzNGNkYjI1NyIsInN1YiI6InN5c3RlbTpzZXJ2aWNlYWNjb3VudDpkZWZhdWx0OmRlZmF1bHQifQ.mgwXytYP_cdcPMnqFqiqwrVoMkCvmtsoBsmAGAwd3_6Gvh0jYZKVmc_KJE-uHVh0s2dV25hVyAqZ5nOc4dOzYucS8N3qrjlHStrJIBz7WlPD_YHP1_krYuRtuvjVebfItG_IDRZt30qtumCXbNfo7q2uPEyVcajJ3Wg9QiFxNHnbc9ZbMDd0v9296UjGg7LGQu5vDTnkuQhDy6OITdj5_m8-e5sL8Z29LsTF125nX_1M9I9nClbmMpPNZ_cNHspphyLM-JM3Pdv45iF4AhvjWYSUug1kz8q3aqeqBKnx-hH6etRvuZrbiO-btYMQKTizgLZ_5g0Rza64ZUkiW23ahA";

    // Start is called before the first frame update
    void Start() {
        // Load from the default kubeconfig on the machine.
        //var config = KubernetesClientConfiguration.BuildConfigFromConfigFile();

        // Use the config object to create a client.
        //var client = new Kubernetes(config);

        //var namespaces = client.ListNamespace();
        //foreach (var ns in namespaces.Items) {
        //    Console.WriteLine(ns.Metadata.Name);
        //    var list = client.ListNamespacedPod(ns.Metadata.Name);
        //    foreach (var item in list.Items) {
        //        Console.WriteLine(item.Metadata.Name);
        //    }
        //}




        //ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
        //client.BaseAddress = new Uri(url);
        //client.DefaultRequestHeaders.Accept.Clear();
        //client.DefaultRequestHeaders.Add("Authorization", "Bearer " +  token);
        //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer " + token);
        //Test();
    }
    async void Test() {
        //HttpResponseMessage response = await client.GetAsync("");
        //Debug.Log(response.StatusCode + ": " + response.ToString());
        //if (response.IsSuccessStatusCode) {
            //product = await response.Content.ReadAsAsync<Product>();
        //}
    }

    // Update is called once per frame
    void Update() {

    }
}
