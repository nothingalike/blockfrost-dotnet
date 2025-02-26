﻿using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Blockfrost.Api
{
    public partial class TransactionService : ABlockfrostService, ITransactionService
    {
        public TransactionService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <summary>Transaction metadata in CBOR</summary>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Obtain information about stake pool retirements within a specific transaction.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ICollection<TxMetadataCborResponse>> CborAsync(string hash)
        {
            return CborAsync(hash, CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Transaction metadata in CBOR</summary>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Obtain information about stake pool retirements within a specific transaction.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ICollection<TxMetadataCborResponse>> CborAsync(string hash, CancellationToken cancellationToken)
        {
            if (hash == null)
                throw new System.ArgumentNullException("hash");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/txs/{hash}/metadata/cbor");
            urlBuilder_.Replace("{hash}", System.Uri.EscapeDataString(ConvertToString(hash, System.Globalization.CultureInfo.InvariantCulture)));

            return await SendGetRequestAsync<ICollection<TxMetadataCborResponse>>(urlBuilder_, cancellationToken);
        }

        /// <summary>Transaction delegation certificates</summary>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Obtain information about delegation certificates of a specific transaction</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ICollection<TxDelegation>> DelegationsAsync(string hash)
        {
            return DelegationsAsync(hash, CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Transaction delegation certificates</summary>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Obtain information about delegation certificates of a specific transaction</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ICollection<TxDelegation>> DelegationsAsync(string hash, CancellationToken cancellationToken)
        {
            if (hash == null)
                throw new System.ArgumentNullException("hash");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/txs/{hash}/delegations");
            urlBuilder_.Replace("{hash}", System.Uri.EscapeDataString(ConvertToString(hash, System.Globalization.CultureInfo.InvariantCulture)));

            return await SendGetRequestAsync<ICollection<TxDelegation>>(urlBuilder_, cancellationToken);
        }

        /// <summary>Transaction metadata</summary>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Obtain information about stake pool retirements within a specific transaction.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ICollection<TxMetadataResponse>> MetadataAllAsync(string hash)
        {
            return MetadataAllAsync(hash, CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Transaction metadata</summary>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Obtain information about stake pool retirements within a specific transaction.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ICollection<TxMetadataResponse>> MetadataAllAsync(string hash, CancellationToken cancellationToken)
        {
            if (hash == null)
                throw new System.ArgumentNullException("hash");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/txs/{hash}/metadata");
            urlBuilder_.Replace("{hash}", System.Uri.EscapeDataString(ConvertToString(hash, System.Globalization.CultureInfo.InvariantCulture)));

            return await SendGetRequestAsync<ICollection<TxMetadataResponse>>(urlBuilder_, cancellationToken);
        }

        /// <summary>Transaction MIRs</summary>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Obtain information about Move Instantaneous Rewards (MIRs) of a specific transaction.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ICollection<TxMir>> MirsAsync(string hash)
        {
            return MirsAsync(hash, CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Transaction MIRs</summary>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Obtain information about Move Instantaneous Rewards (MIRs) of a specific transaction.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ICollection<TxMir>> MirsAsync(string hash, CancellationToken cancellationToken)
        {
            if (hash == null)
                throw new System.ArgumentNullException("hash");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/txs/{hash}/mirs");
            urlBuilder_.Replace("{hash}", System.Uri.EscapeDataString(ConvertToString(hash, System.Globalization.CultureInfo.InvariantCulture)));

            return await SendGetRequestAsync<ICollection<TxMir>>(urlBuilder_, cancellationToken);
        }

        /// <summary>Transaction stake addresses certificates</summary>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Obtain information about (de)registration of stake addresses within a transaction.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ICollection<TxStakeAddress>> Stakes3Async(string hash)
        {
            return Stakes3Async(hash, CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Transaction stake addresses certificates</summary>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Obtain information about (de)registration of stake addresses within a transaction.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ICollection<TxStakeAddress>> Stakes3Async(string hash, CancellationToken cancellationToken)
        {
            if (hash == null)
                throw new System.ArgumentNullException("hash");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/txs/{hash}/stakes");
            urlBuilder_.Replace("{hash}", System.Uri.EscapeDataString(ConvertToString(hash, System.Globalization.CultureInfo.InvariantCulture)));

            return await SendGetRequestAsync<ICollection<TxStakeAddress>>(urlBuilder_, cancellationToken);
        }

        /// <summary>Specific transaction</summary>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Return the contents of the transaction.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<TxContentResponse> TxsAsync(string hash)
        {
            return TxsAsync(hash, CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Specific transaction</summary>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Return the contents of the transaction.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<TxContentResponse> TxsAsync(string hash, CancellationToken cancellationToken)
        {
            if (hash == null)
                throw new System.ArgumentNullException("hash");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/txs/{hash}");
            urlBuilder_.Replace("{hash}", System.Uri.EscapeDataString(ConvertToString(hash, System.Globalization.CultureInfo.InvariantCulture)));

            return await SendGetRequestAsync<TxContentResponse>(urlBuilder_, cancellationToken);
        }

        /// <summary>Transaction UTXOs</summary>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Return the contents of the transaction.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<TxContentUTxOResponse> UtxosAsync(string hash)
        {
            return UtxosAsync(hash, CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Transaction UTXOs</summary>
        /// <param name="hash">Hash of the requested transaction</param>
        /// <returns>Return the contents of the transaction.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<TxContentUTxOResponse> UtxosAsync(string hash, CancellationToken cancellationToken)
        {
            if (hash == null)
                throw new System.ArgumentNullException("hash");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/txs/{hash}/utxos");
            urlBuilder_.Replace("{hash}", System.Uri.EscapeDataString(ConvertToString(hash, System.Globalization.CultureInfo.InvariantCulture)));

            return await SendGetRequestAsync<TxContentUTxOResponse>(urlBuilder_, cancellationToken);
        }

        /// <summary>Transaction withdrawal</summary>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Obtain information about withdrawals of a specific transaction.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ICollection<TxWithdawal>> WithdrawalsAsync(string hash)
        {
            return WithdrawalsAsync(hash, CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Transaction withdrawal</summary>
        /// <param name="hash">Hash of the requested transaction.</param>
        /// <returns>Obtain information about withdrawals of a specific transaction.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ICollection<TxWithdawal>> WithdrawalsAsync(string hash, CancellationToken cancellationToken)
        {
            if (hash == null)
                throw new System.ArgumentNullException("hash");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/txs/{hash}/withdrawals");
            urlBuilder_.Replace("{hash}", System.Uri.EscapeDataString(ConvertToString(hash, System.Globalization.CultureInfo.InvariantCulture)));

            return await SendGetRequestAsync<ICollection<TxWithdawal>>(urlBuilder_, cancellationToken);
        }

        /// <summary>Submit a transaction</summary>
        /// <returns>Return the ID of the submitted transaction.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<string> SubmitAsync(string content)
        {
            return SubmitAsync(content, CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Submit a transaction</summary>
        /// <returns>Return the ID of the submitted transaction.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<string> SubmitAsync(string content, CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/tx/submit");

            return await SendPostRequestAsync<string>(content, urlBuilder_, cancellationToken);
        }

                /// <summary>Submit a transaction</summary>
        /// <returns>Return the ID of the submitted transaction.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<string> SubmitAsync(Stream content)
        {
            return SubmitAsync(content, CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Submit a transaction</summary>
        /// <returns>Return the ID of the submitted transaction.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<string> SubmitAsync(Stream content, CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/tx/submit");

            return await SendPostRequestAsync<string>(content, urlBuilder_, cancellationToken);
        }
    }
}
