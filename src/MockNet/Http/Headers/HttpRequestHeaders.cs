using System;
using SystemHttpRequestHeaders = System.Net.Http.Headers.HttpRequestHeaders;
using SystemMediaTypeWithQualityHeaderValue = System.Net.Http.Headers.MediaTypeWithQualityHeaderValue;
using SystemTransferCodingWithQualityHeaderValue = System.Net.Http.Headers.TransferCodingWithQualityHeaderValue;
using SystemNameValueWithParametersHeaderValue = System.Net.Http.Headers.NameValueWithParametersHeaderValue;
using SystemStringWithQualityHeaderValue = System.Net.Http.Headers.StringWithQualityHeaderValue;
using SystemProductInfoHeaderValue = System.Net.Http.Headers.ProductInfoHeaderValue;
using SystemProductHeaderValue = System.Net.Http.Headers.ProductHeaderValue;
using SystemTransferCodingHeaderValue = System.Net.Http.Headers.TransferCodingHeaderValue;
using SystemNameValueHeaderValue = System.Net.Http.Headers.NameValueHeaderValue;
using SystemViaHeaderValue = System.Net.Http.Headers.ViaHeaderValue;
using SystemEntityTagHeaderValue = System.Net.Http.Headers.EntityTagHeaderValue;
using SystemWarningHeaderValue = System.Net.Http.Headers.WarningHeaderValue;
using SystemHttpContentHeaders = System.Net.Http.Headers.HttpContentHeaders;

namespace Theorem.MockNet.Http
{
    public sealed class HttpRequestHeaders : HttpHeaders
    {
        private readonly HttpContentHeaders contentHeaders;

        internal HttpRequestHeaders(SystemHttpRequestHeaders store, SystemHttpContentHeaders contentHeadersStore)
        {
            this.store = store ?? throw new ArgumentNullException(nameof(store));
            contentHeaders = new HttpContentHeaders(contentHeadersStore);
        }

        internal SystemHttpRequestHeaders Store => store as SystemHttpRequestHeaders;

        public HttpHeaderValueCollection<MediaTypeWithQualityHeaderValue, SystemMediaTypeWithQualityHeaderValue> Accept => new HttpHeaderValueCollection<MediaTypeWithQualityHeaderValue, SystemMediaTypeWithQualityHeaderValue>(Store.Accept, x => (MediaTypeWithQualityHeaderValue)x);
        public HttpHeaderValueCollection<ProductInfoHeaderValue, SystemProductInfoHeaderValue> UserAgent => new HttpHeaderValueCollection<ProductInfoHeaderValue, SystemProductInfoHeaderValue>(Store.UserAgent, x => (ProductInfoHeaderValue)x);
        public HttpHeaderValueCollection<ProductHeaderValue, SystemProductHeaderValue> Upgrade => new HttpHeaderValueCollection<ProductHeaderValue, SystemProductHeaderValue>(Store.Upgrade, x => (ProductHeaderValue)x);
        public bool? TransferEncodingChunked { get => Store.TransferEncodingChunked; set => Store.TransferEncodingChunked = value; }
        public HttpHeaderValueCollection<TransferCodingHeaderValue, SystemTransferCodingHeaderValue> TransferEncoding => new HttpHeaderValueCollection<TransferCodingHeaderValue, SystemTransferCodingHeaderValue>(Store.TransferEncoding, x => (TransferCodingHeaderValue)x);
        public HttpHeaderValueCollection<string> Trailer => new HttpHeaderValueCollection<string>(Store.Trailer);
        public HttpHeaderValueCollection<TransferCodingWithQualityHeaderValue, SystemTransferCodingWithQualityHeaderValue> TE => new HttpHeaderValueCollection<TransferCodingWithQualityHeaderValue, SystemTransferCodingWithQualityHeaderValue>(Store.TE, x => (TransferCodingWithQualityHeaderValue)x);
        public Uri Referrer { get => Store.Referrer; set => Store.Referrer = value; }
        public RangeHeaderValue Range { get => Store.Range; set => Store.Range = value; }
        public AuthenticationHeaderValue ProxyAuthorization { get => Store.ProxyAuthorization; set => Store.ProxyAuthorization = value; }
        public HttpHeaderValueCollection<NameValueHeaderValue, SystemNameValueHeaderValue> Pragma => new HttpHeaderValueCollection<NameValueHeaderValue, SystemNameValueHeaderValue>(Store.Pragma, x => (NameValueHeaderValue)x);
        public int? MaxForwards { get => Store.MaxForwards; set => Store.MaxForwards = value; }
        public DateTimeOffset? IfUnmodifiedSince { get => Store.IfUnmodifiedSince; set => Store.IfUnmodifiedSince = value; }
        public RangeConditionHeaderValue IfRange { get => Store.IfRange; set => Store.IfRange = value; }
        public HttpHeaderValueCollection<ViaHeaderValue, SystemViaHeaderValue> Via => new HttpHeaderValueCollection<ViaHeaderValue, SystemViaHeaderValue>(Store.Via, x => (ViaHeaderValue)x);
        public HttpHeaderValueCollection<EntityTagHeaderValue, SystemEntityTagHeaderValue> IfNoneMatch => new HttpHeaderValueCollection<EntityTagHeaderValue, SystemEntityTagHeaderValue>(Store.IfNoneMatch, x => (EntityTagHeaderValue)x);
        public HttpHeaderValueCollection<EntityTagHeaderValue, SystemEntityTagHeaderValue> IfMatch => new HttpHeaderValueCollection<EntityTagHeaderValue, SystemEntityTagHeaderValue>(Store.IfMatch, x => (EntityTagHeaderValue)x);
        public string Host { get => Store.Host; set => Store.Host = value; }
        public string From { get => Store.From; set => Store.From = value; }
        public bool? ExpectContinue { get => Store.ExpectContinue; set => Store.ExpectContinue = value; }
        public HttpHeaderValueCollection<NameValueWithParametersHeaderValue, SystemNameValueWithParametersHeaderValue> Expect => new HttpHeaderValueCollection<NameValueWithParametersHeaderValue, SystemNameValueWithParametersHeaderValue>(Store.Expect, x => (NameValueWithParametersHeaderValue)x);
        public DateTimeOffset? Date { get => Store.Date; set => Store.Date = value; }
        public bool? ConnectionClose { get => Store.ConnectionClose; set => Store.ConnectionClose = value; }
        public HttpHeaderValueCollection<string> Connection => new HttpHeaderValueCollection<string>(Store.Connection);
        public CacheControlHeaderValue CacheControl { get => Store.CacheControl; set => Store.CacheControl = value; }
        public AuthenticationHeaderValue Authorization { get => Store.Authorization; set => Store.Authorization = value; }
        public HttpHeaderValueCollection<StringWithQualityHeaderValue, SystemStringWithQualityHeaderValue> AcceptLanguage => new HttpHeaderValueCollection<StringWithQualityHeaderValue, SystemStringWithQualityHeaderValue>(Store.AcceptLanguage, x => (StringWithQualityHeaderValue)x);
        public HttpHeaderValueCollection<StringWithQualityHeaderValue, SystemStringWithQualityHeaderValue> AcceptEncoding => new HttpHeaderValueCollection<StringWithQualityHeaderValue, SystemStringWithQualityHeaderValue>(Store.AcceptEncoding, x => (StringWithQualityHeaderValue)x);
        public HttpHeaderValueCollection<StringWithQualityHeaderValue, SystemStringWithQualityHeaderValue> AcceptCharset => new HttpHeaderValueCollection<StringWithQualityHeaderValue, SystemStringWithQualityHeaderValue>(Store.AcceptCharset, x => (StringWithQualityHeaderValue)x);
        public DateTimeOffset? IfModifiedSince { get; set; }
        public HttpHeaderValueCollection<WarningHeaderValue, SystemWarningHeaderValue> Warning => new HttpHeaderValueCollection<WarningHeaderValue, SystemWarningHeaderValue>(Store.Warning, x => (WarningHeaderValue)x);

        #region Content headers

        public HttpHeaderValueCollection<string> Allow => contentHeaders.Allow;
        public ContentDispositionHeaderValue ContentDisposition => contentHeaders.ContentDisposition;
        public HttpHeaderValueCollection<string> ContentEncoding => contentHeaders.ContentEncoding;
        public HttpHeaderValueCollection<string> ContentLanguage => contentHeaders.ContentLanguage;
        public long? ContentLength => contentHeaders.ContentLength;
        public Uri ContentLocation => contentHeaders.ContentLocation;
        public byte[] ContentMD5 => contentHeaders.ContentMD5;
        public ContentRangeHeaderValue ContentRange => contentHeaders.ContentRange;
        public MediaTypeHeaderValue ContentType => contentHeaders.ContentType;
        public DateTimeOffset? Expires => contentHeaders.Expires;
        public DateTimeOffset? LastModified => contentHeaders.LastModified;

        #endregion
    }
}